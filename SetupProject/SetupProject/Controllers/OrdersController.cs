using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SetupProject.DAL;
using SetupProject.Models;
using SetupProject.Utilities;
using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SetupProject.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Order
        [Authorize(Roles = "Customer, Employee, Manager")]
        public IActionResult Index()
        {
            List<Order> Orders = new List<Order>();
            if (User.IsInRole("Customer"))
            {

                Orders = _context.Orders
                                 .Include(c => c.OrderDetails)
                                 .Where(c => c.Customer.UserName == User.Identity.Name)
                                 .Where(c => c.CompleteStatus == CompleteStatus.Complete)
                                 .OrderByDescending(c => c.OrderNumber)
                                 .ToList();
            }
            else
            {

                Orders = _context.Orders
                                .Include(c => c.OrderDetails)
                                .Where(c => c.CompleteStatus == CompleteStatus.Complete)
                                .OrderByDescending(c => c.OrderNumber)
                                .ToList();
            }
            return View(Orders);

        }



        // GET: Order/Details/5
        [Authorize(Roles = "Customer, Employee, Manager")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "Order id does not exist" });
            }

            var order = await _context.Orders
                                      .Include(m => m.OrderDetails)
                                      .ThenInclude(m => m.Book)
                                      .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }





        //GET
        [Authorize(Roles = "Customer")]
        public IActionResult Cart()
        {
      
            Order order = _context.Orders
                                    .Include(c => c.Promotion)
                                    .Include(o => o.Customer)
                                    .Include(m => m.OrderDetails)
                                    .ThenInclude(m => m.Book)
                                    .Where(c => c.CompleteStatus == CompleteStatus.InComplete)
                                    .Where(c => c.Customer.UserName == User.Identity.Name)
                                    .FirstOrDefault();


            if (order == null)
            {
                return View("Error", new string[] { "You do not have any orders!" });
            }
            else
            {
                if (order.OrderDetails.Count() == 0)
                {
                    return View("Error", new string[] { "You do not have any orders!" });
                }
                else
                {
                    foreach (OrderDetail detail in order.OrderDetails.ToList())
                    {
                        detail.BookPrice = detail.Book.Price;

                        _context.OrderDetails.Update(detail);
                        _context.SaveChanges();

                        if (detail.Book.Inventory == 0)
                        {
                            _context.OrderDetails.Remove(detail);
                            _context.SaveChanges();
                            ViewBag.OutOfStock = detail.Book.Title + " is currently out of stock. It has been removed from your cart.";

                        }
                        if (detail.Book.Discontinued == true)
                        {
                            Order orderCustomer = _context.Orders
                                                          .Include(c => c.Customer)
                                                          .FirstOrDefault(c => c.OrderID == order.OrderID);

                            //send email//send email
                            String bookTitle = detail.Book.Title;
                            String bookAuthor = detail.Book.Author;
                            AppUser customer = orderCustomer.Customer;
                            String emailsubject = "Team 12: Item in Cart is Discontinued";
                            String emailbody = "The following book you have in your cart has been discontinued." + "\nBook: " + bookTitle + "\nAuthor: " + bookAuthor;

                            OrdersController.SendEmail(customer.Email, emailbody, emailsubject);

                            
                            _context.OrderDetails.Remove(detail);
                            _context.SaveChanges();

                            ViewBag.BookDiscontinued = detail.Book.Title + " has been discontinued. It has been removed from your cart";

                        }
                    }
                    ShippingCosts currentShippingCosts = _context.ShippingCosts.FirstOrDefault();


                    order.ShippingCost = 0;

                    int count = 0;

                    foreach (OrderDetail detail in order.OrderDetails.ToList())
                    {
                        if (count == 0) //if this is the first order detail
                        {
                            if (detail.BookQuantity == 1)
                            {
                                order.ShippingCost = currentShippingCosts.FirstBookShipCost;
                            }
                            else //more than 1 book in the orderdetail
                            {
                                order.ShippingCost = currentShippingCosts.FirstBookShipCost + ((detail.BookQuantity - 1) * currentShippingCosts.AddBookShipCost);
                            }
                        }
                        else //all other orderdetails
                        {
                            order.ShippingCost += currentShippingCosts.AddBookShipCost * detail.BookQuantity;
                        }
                        count += 1;
                    }



                    _context.Update(order);
                    _context.SaveChanges();
                    return View(order);
                }
            }
        }



        //GET Checkout
        [Authorize(Roles = "Customer")]
        public IActionResult Checkout(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "You must specify an order to place!" });
            }

            Order order = _context.Orders
                                  .Include(c => c.Promotion)
                                  .Include(c => c.OrderDetails)
                                  .ThenInclude(c => c.Book)
                                  .Where(c => c.CompleteStatus == CompleteStatus.InComplete)
                                  .Where(c => c.Customer.UserName == User.Identity.Name)
                                  .FirstOrDefault();


            int detailCount = order.OrderDetails.Count();

            if (order == null)
            {
                return View("Error", new string[] { "Order is not found!" });
            }
            if (detailCount == 0)
            {
                return View("Error", new string[] { "No items in cart!" });
            }


            String userid = User.Identity.Name;

            ViewBag.creditcards = GetAllCreditCards(userid);

            return View("Checkout", order);
        }



        [Authorize(Roles = "Customer")]
        public IActionResult PlacedOrder(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "You must specify an order to place!" });
            }

            //decrease the inventory for books that are ordered
            List<OrderDetail> allorderdetails = new List<OrderDetail>();
            var query = _context.OrderDetails
                                 .Include(m => m.Book)
                                 .Include(r => r.Order)
                                 .ThenInclude(m => m.Customer);
                                 
            allorderdetails = query.ToList();

           
            foreach (OrderDetail detail in allorderdetails)
            {
                if (detail.Order.OrderID == id)
                {
                    detail.Book.Inventory -= detail.BookQuantity;
                    _context.SaveChanges();
                }
            }

            var order = _context.Orders
                                .Include(r => r.Promotion)
                                .Include(r => r.OrderDetails)
                                .ThenInclude(r => r.Book)
                                .Include(r => r.Customer)
                                .FirstOrDefault(r => r.OrderID == id);

            if (order == null)
            {
                return View("Error", new string[] { "Order not found!" });
            }

            Promotion isPromoSaved = order.Promotion;

            //once order is placed to be complete
            order.CompleteStatus = CompleteStatus.Complete;
            order.OrderDate = System.DateTime.Today;
            order.OrderNumber = GenerateNextOrderNumber.GetNextOrderNumber(_context);

            _context.Orders.Update(order);
            _context.SaveChanges();


            var query1 = from r in _context.OrderDetails
                                            .Include(r => r.Order)
                                            .Include(r => r.Book) select r;

            List<OrderDetail> orderdetails = query1
                                                  .Where(r => r.Order.OrderID == order.OrderID)
                                                  .ToList();

            string userName = User.Identity.Name;
            AppUser currentuser = _context.Users.FirstOrDefault(r => r.UserName == userName);


            String strOrderDetail = "";

            foreach (OrderDetail detail in orderdetails)
            {
                strOrderDetail += detail.Book.Title + " | " + detail.BookQuantity + " | $" + detail.BookPrice + " | $" + detail.SumPrice + "\n";
            }

            String emailsubject = "New Order";
            String emailbody = "Thank you for your order! Below is your order summary. " + "\n" +
                "Title         " + "Quantity      " + "Price     " + "Book Total       " + "\n" +
                strOrderDetail + "\n" +
                "Order Summary:" + "\n" +
                "Subtotal: $" + order.OrderSubtotal + "\n" +
                                     "Shipping Cost: $" + order.ShippingCost + "\n" +
                                     "Total: $" + order.OrderTotal;
            SendEmail(currentuser.Email, emailbody, emailsubject);


            return View("PlacedOrder", order);

        }



        //GET: AddBook
        [Authorize]
        public IActionResult AddBook(int? id)
        {
            Book book = _context.Books.Find(id);

            book.Inventory = GetBookInventory(book);


            if (book.Inventory == 0)
            {
                return View("Error", new string[] { "This book is out of stock, Go back to the list" });

            }

            else
            {
                String userName = User.Identity.Name;
                AppUser currentUser = _context.Users.FirstOrDefault(r => r.UserName == userName);

                var orderquery = from r in _context.OrderDetails
                                                   .Include(r => r.Book)
                                                   .Include(r => r.Order)
                                                   .ThenInclude(r => r.Customer) select r;

                orderquery = orderquery
                            .Where(r => r.Order.Customer.UserName == currentUser.UserName && r.Order.CompleteStatus == CompleteStatus.InComplete);


                List<OrderDetail> currentorddetails = orderquery.ToList();
                List<Book> booksinorder = new List<Book>();

                if (currentorddetails.Count() != 0)
                {
                    foreach (OrderDetail orddetail in currentorddetails)
                    {
                        booksinorder.Add(orddetail.Book);
                    }

                    foreach (Book bk in booksinorder)
                    {
                        if (bk.Title == book.Title)
                        {
                            ViewBag.CannotReAdd = "You cannot add this book to your order. It is already in your cart.";
                            return RedirectToAction("Details", "Search", new { id = id}); //book id
                        }

                    }
                }


                //create a new order detail for the book for the shopping cart order
                OrderDetail detail = new OrderDetail { };

                //add values for all other fields for orderDetail
                detail.Book = book;
                detail.BookPrice = detail.Book.Price;
                detail.BookQuantity = 1;

                _context.OrderDetails.Add(detail);
                _context.SaveChanges();


                Order ShoppingCartOrder = _context.Orders
                                                   .Include(c => c.OrderDetails)
                                                    .Where(c => c.CompleteStatus == CompleteStatus.InComplete)
                                                    .Where(c => c.Customer.UserName == User.Identity.Name).FirstOrDefault();

                ShippingCosts currentShipCosts = _context.ShippingCosts.FirstOrDefault();


                if (ShoppingCartOrder == null) 
                {

                    ShoppingCartOrder = new Order { };

                    ShoppingCartOrder.OrderNumber = GenerateNextOrderNumber.GetNextOrderNumber(_context);

                    ShoppingCartOrder.OrderDate = System.DateTime.Today;

                    //ShoppingCartOrder.ShippingCost = 3.50m; //because this is the first book being added to order
                    ShoppingCartOrder.ShippingCost = currentShipCosts.FirstBookShipCost;

                    ShoppingCartOrder.CompleteStatus = CompleteStatus.InComplete; //makes this the shopping cart

                    detail.Order = ShoppingCartOrder;

                    //how to add customer to an order
                    String userid = User.Identity.Name;
                    AppUser user = _context.Users.FirstOrDefault(u => u.UserName == userid);
                    ShoppingCartOrder.Customer = user; //THIS IS THROWING ERROR WITH IDENTITY_INSERT

                    _context.Orders.Add(ShoppingCartOrder);
                    _context.SaveChanges();
                 }
                else
                {
                    _context.SaveChanges();

                    ShoppingCartOrder.OrderDate = System.DateTime.Today;

                    ShoppingCartOrder.OrderDetails.Add(detail);

                    int orderDetailCount = ShoppingCartOrder.OrderDetails.Count();

                    //check if there's another book in the order already
                    //if (existingCart.OrderDetails.Count() > 1) //there is another order detail connected to the existing open order
                    if (orderDetailCount > 1)
                    {
                        //ShoppingCartOrder.ShippingCost = 1.50m + ShoppingCartOrder.ShippingCost;
                        ShoppingCartOrder.ShippingCost = currentShipCosts.AddBookShipCost + ShoppingCartOrder.ShippingCost;
                    }
                    else
                    {
                        //ShoppingCartOrder.ShippingCost = 3.50m; //add 1.50 each additional book if one is already in cart
                        ShoppingCartOrder.ShippingCost = currentShipCosts.FirstBookShipCost;
                    }

                    _context.SaveChanges();

                }

                return RedirectToAction("Cart", "Orders", new { id = detail.Book.BookID });


            }
        }


        [HttpPost]
        [Authorize(Roles = "Customer")]
        public IActionResult EnterPromo(string promoCode, int orderId) 
        {
            Order order = _context.Orders
                                  .Include(c => c.Promotion)
                                  .Include(c => c.OrderDetails)
                                  .ThenInclude(c => c.Book)
                                  .FirstOrDefault(c => c.OrderID == orderId);
            

            String userid = User.Identity.Name;
            //ViewBag.creditcards = GetAllCreditCards(userid);
            var allOrders = _context.Orders
                                    .Include(c => c.Promotion)
                                    .Include(c => c.Customer)
                                    .Where(c => c.Customer.UserName == userid)
                                    .ToList();

            List<Promotion> promotionUsed = new List<Promotion>();

            foreach (Order ord in allOrders) 
            {
                if (ord.Promotion != null) //if they used a promo on a previous order
                {
                    promotionUsed.Add(ord.Promotion); //add promo to a list of all promos used
                }
            }


            if (order.Promotion == null) // don't applied coupon yet
            {

                var promos = _context.Promotions.ToList();

                foreach (Promotion item in promos)
                {
                    if (item.PromoCode == promoCode)
                    {
                        if (item.Status)
                        {
                            if (promotionUsed.Count() != 0)
                            {
                                foreach (Promotion promo in promotionUsed)
                                {
                                    if (promo.PromoCode == promoCode)
                                    {
                                        ViewBag.creditcards = GetAllCreditCards(userid);
                                        ViewBag.PromoError = "You have already used this coupon.";
                                        return View("Checkout", order);
                                    }
                                }
                            }

                            if (order.OrderSubtotal > item.MinimumSpend) //if the customer spent enough to use this promo
                            {
                                if (item.ShipWaiver) //promo applies to shippingCost
                                {
                                    //set shipping cost to 0
                                    order.ShippingCost = 0m;
                                    order.Promotion = item;
                                    _context.Orders.Update(order);
                                    _context.SaveChanges();
                                    ViewBag.creditcards = GetAllCreditCards(userid);
                                    return View("Checkout", order);
                                }
                                else
                                {

                                    foreach (OrderDetail od in order.OrderDetails)
                                    {
                                        od.BookPrice = od.BookPrice - (od.BookPrice * (item.DiscountAmount));

                                        //_context.OrderDetails.Update(od);
                                        _context.SaveChanges();
                                        //do I need to attach this updated orderDetail to this order??/save it


                                    }
                                    order.Promotion = item;

                                    _context.Orders.Update(order);
                                    _context.SaveChanges();
                                    //return RedirectToAction("Checkout", new { id = order.OrderID });
                                    ViewBag.creditcards = GetAllCreditCards(userid);
                                    return View("Checkout", order); //od is not staying connected to order through the pass back to view
                                                                    //when passing this order, some value is null that goes into calculating the subtotal (od.ExtendedPrice???)
                                }
                            }
                            else //if they didnt meet the minimum spending amount
                            {
                                ViewBag.creditcards = GetAllCreditCards(userid);
                                ViewBag.PromoError = "You did not meet the minimum spending requirement to use this coupon.";
                                return View("Checkout", order);
                            }

                        }
                        else //if coupon is not enabled
                        {
                            ViewBag.creditcards = GetAllCreditCards(userid);
                            ViewBag.PromoError = "This coupon is not available for use at this time.";
                            return View("Checkout", order);

                        }

                    }
                }
                ViewBag.creditcards = GetAllCreditCards(userid);
                ViewBag.PromoError = "Invalid coupon code.";
                return View("Checkout", order);

            }
            //already used coupon
            ViewBag.creditcards = GetAllCreditCards(userid);
            ViewBag.PromoError = "You have already applied a coupon to this order.";
            return View("Checkout", order);
        }
   


        public int GetBookInventory(Book BookID)
        {
            int bookInventory = BookID.Inventory;
            return bookInventory;
        }



        //Credit Card List
        private SelectList GetAllCreditCards(string userid)
        {
            AppUser user = _context.Users
                                    .Include(r => r.PaymentMethods)
                                    .FirstOrDefault(u => u.UserName == userid);

            List<String> creditcards = new List<string>();

            
            SelectList allCreditCards = new SelectList(creditcards, "CreditCards");
            return allCreditCards;
        }



        //Send email
        public static void SendEmail(string ToAddress, string emailBody, string emailSubject)
        {
            String fromAddress = "t03131553@gmail.com";
            String fromPassword = "Abc123!!";
            String fromCompanyName = "MIS 333K Final Project Team 12";

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress, fromPassword),
                EnableSsl = true
            };

            String finalMessage = emailBody + "\n\n Thank you.";

            //Create an email address object for the sender address
            MailAddress senderEmail = new MailAddress(fromAddress, fromCompanyName);

            //Create a new mail message
            MailMessage mm = new MailMessage();

            //Set the subject line of the message (including your team number)
            //TODO: Change XX to your team number.
            mm.Subject = "Team 12 - " + emailSubject;

            //Set the sender address
            mm.Sender = senderEmail;

            //Set the from address
            mm.From = senderEmail;

            //Add the recipient (passed in as a parameter) to the list of people receiving the email
            mm.To.Add(new MailAddress(ToAddress));

            //Add the message (passed)
            mm.Body = finalMessage;

            //send the message!
            client.Send(mm);
        }


    }
}







