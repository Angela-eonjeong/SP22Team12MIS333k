using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SetupProject.DAL;
using SetupProject.Models;

namespace SetupProject.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _context;

        public ReviewsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reviews
        [Authorize]
        public IActionResult Index()
        {

            List<Book> books = new List<Book>();
            List<List<OrderDetail>> listorderdetails = new List<List<OrderDetail>>();
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            List<Order> orders = new List<Order>();

            if (User.IsInRole("Customer"))
            {
                orders = _context.Orders
                                .Include(c => c.OrderDetails)
                                .ThenInclude(c => c.Book)
                                .Where(c => c.Customer.UserName == User.Identity.Name)
                                .Where(c => c.CompleteStatus == CompleteStatus.Complete)
                                .ToList();
                foreach (var or in orders)
                {
                    listorderdetails.Add(or.OrderDetails);
                }
                foreach (var orddetaillist in listorderdetails)
                {
                    foreach (var orddetail in orddetaillist)
                    {
                        orderDetails.Add(orddetail);
                    }
                }
                foreach (var orddlt in orderDetails)
                {
                    books.Add(orddlt.Book);
                }

                List<Book> noduplicatebooks = books.Distinct().ToList();

                return View(noduplicatebooks);


            }
            else
            {
                var query = from r in _context.Reviews
                                            .Include(r => r.Author)
                                            .Include(r => r.Book) select r;
                query = query.Where(r => r.ApprovalStatus == ApprovalStatus.Pending);
      //          query = query.Where(r => r.Author != null);
                List<Review> notapprovedlist = query.ToList();
                return View("ManagerEmployeeIndex", notapprovedlist);
            }

        }

        // GET: Reviews/Details/5
        [Authorize]
        public IActionResult Details(int? id)
        {
            String username = User.Identity.Name;


            var query = from r in _context.Reviews
                                         .Include(r => r.Book)
                                         .Include(r => r.Author)
                                         .ThenInclude(r => r.Orders)
                                          select r;

            Review reviewtodisplay = query
                                          .Where(r => r.Book.BookID == id && r.Author.UserName == username)
                                        //  .OrderByDescending(r => r.Orders.OrderDate)
                                          .FirstOrDefault();


            if (reviewtodisplay == null)
            {
                return View("Error", new string[] { "Review has not been created yet. Please create a review for this book." });
            }

            return View(reviewtodisplay);
        }

        // GET: Review/Create
        [Authorize(Roles = "Customer")]
        public IActionResult Create(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            String userName = User.Identity.Name;

            //check to see if this review has already been created
            AppUser currentuser = _context.Users.FirstOrDefault(r => r.UserName == userName);

            var orderquery = from r in _context.OrderDetails
                                              .Include(r => r.Book)
                                              .Include(r => r.Order)
                                              .ThenInclude(r => r.Customer)
                                               select r;

            orderquery = orderquery
                                    .Where(r => r.Order.Customer.UserName == currentuser.UserName && r.Order.CompleteStatus == CompleteStatus.Complete);


            List<OrderDetail> currentorddetails = orderquery.ToList();
            List<Book> booksinorder = new List<Book>();

            if (currentorddetails.Count() != 0)
            {
                foreach (OrderDetail orddetail in currentorddetails)
                {
                    booksinorder.Add(orddetail.Book);
                }
            }

            Boolean bookbought = false;

            foreach (Book bk in booksinorder)
            {
                if (bk.BookID == id)
                {
                    bookbought = true;
                    break;
                }
                else
                {
                    bookbought = false;

                }

            }


            if (bookbought == true)
            {
                var query = from r in _context.Reviews
                                            .Include(r => r.Book)
                                            .Include(r => r.Author)
                                             select r;

                query = query.Where(r => r.Book.BookID == id);

                query = query.Where(r => r.Author.UserName == userName);

                List<Review> listreviews = query.ToList();

                if (listreviews.Count == 0)
                {
                    Review review = new Review();
                    Book book = _context.Books.FirstOrDefault(m => m.BookID == id);
                    review.Book = book;
                    _context.Add(review);
                    _context.SaveChangesAsync();


                    ViewBag.TextError = "";
                    return View(review);
                }
                else
                {
                    return View("Error", new string[] { "Review already created. Cannot create more than one review for a book." });

                }

            }
            else
            {
                return View("Error", new string[] { "You have not bought this book yet." });

            }




        }



        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> Create([Bind("ReviewID,Description,Rating")] Review review, Int16 Rating, string Description, int id)
        {
            if (ModelState.IsValid)
            {
                String userId = User.Identity.Name;
                AppUser currentuser = _context.Users.FirstOrDefault(u => u.UserName == userId);
                Review newreview = new Review();
                Book book = _context.Books.Include(m => m.Reviews).FirstOrDefault(m => m.BookID == id);
                newreview.Book = book;
                newreview.Author = currentuser;
                newreview.Rating = Rating;
                newreview.Description = Description;
                newreview.ApprovalStatus = ApprovalStatus.Pending;
                book.Reviews.Add(newreview);
                _context.Update(book);
                _context.Update(newreview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(review);
        }



        ///////// Approval

        [Authorize(Roles = "Admin, Employee")]
        public IActionResult Approve(int? id)
        {
            String userId = User.Identity.Name;

            Review currentreview = _context.Reviews
                                           .FirstOrDefault(r => r.ReviewID == id);
            currentreview.ApprovalStatus = ApprovalStatus.Yes;
            _context.Update(currentreview);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }





        [Authorize(Roles = "Admin, Employee")]
        public IActionResult Reject(int? id)
        {
            String userId = User.Identity.Name;
            Review currentreview = _context.Reviews
                                            .FirstOrDefault(r => r.ReviewID == id);
            currentreview.ApprovalStatus = ApprovalStatus.No;
            _context.Update(currentreview);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



        [Authorize(Roles = "Admin, Employee")]
        public ActionResult AllReviews()
        {
            var query = from r in _context.Reviews
                                          .Include(r => r.Book)
                                          .Include(r => r.Author)
                                          select r;
            //query = query.Where(r => r.Author != null);
            List<Review> listofreviews = query.ToList();
            return View("AllReviews", listofreviews);
        }


        public ActionResult ReviewsForBook(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "Book not found" });
            }
            Book book = _context.Books.FirstOrDefault(r => r.BookID == id);
            if (book == null)
            {
                return View("Error", new string[] { "Book not found" });
            }

            var query = from r in _context.Reviews
                                        .Include(r => r.Book)
                                        .Where(r => r.Book.BookID == id && r.ApprovalStatus == ApprovalStatus.Yes)
                                        select r;
            List<Review> reviews = query.ToList();
            return View(reviews);
        }




        /// Edit 
        // GET: Review/Edit/5
        [Authorize(Roles = "Admin, Employee")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //new
            Review review =  _context.Reviews
                                    .Include(o => o.Book)
                                    .ThenInclude(o => o.OrderDetails)
                                    .ThenInclude(o => o.Order)
                                    .Include(o => o.Author)
                                    .FirstOrDefault(o => o.ReviewID == id);

            //var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }



        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> Edit(int id, Review review)
        {
            if (id != review.ReviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //new
                    Review dbReview = _context.Reviews.Find(review.ReviewID);
                    dbReview.Description = review.Description;
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.ReviewID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));

            }
            return RedirectToAction(nameof(AllReviews));
        }

        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.ReviewID == id);
        }


    }


}

