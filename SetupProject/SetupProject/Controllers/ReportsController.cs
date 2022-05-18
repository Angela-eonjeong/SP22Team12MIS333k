using Microsoft.AspNetCore.Mvc;
using SetupProject.DAL;
using SetupProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using SetupProject.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace SetupProject.Controllers
{
    public enum SortReport { MostRecent, ProfitMarginAsc, ProfitMarginDesc, PriceAsc, PriceDesc, MostPopular, Ascending, Descending }
    public enum ReviewOptions { EmpNum, Accept, Reject }

    public class ReportsController : Controller
    {
        private AppDbContext _db;
        private UserManager<AppUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public ReportsController(AppDbContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: /<controller>/
        [Authorize(Roles = "Admin")]
        public IActionResult ChooseReport()
        {
            return View();
        }



        // GET: /<controller>/
        [Authorize(Roles = "Admin")]
        public IActionResult SortSelectionA()
        {
            return View();
        }


       /// All Book
        [Authorize(Roles = "Admin")]
        public ActionResult AllBooksSold(SortReport SelectedSort, String ProfitMin, String ProfitMax, String PriceMin, String PriceMax)
        {
            
            List<AllBooksReportViewModel> allBooksReports = new List<AllBooksReportViewModel>();

            List<OrderDetail> BooksReport = new List<OrderDetail>();
            var query = from r in _db.OrderDetails select r;
            BooksReport = query.ToList();

            if (!string.IsNullOrEmpty(ProfitMin))
            {
                decimal decProfitMin;

                try
                {
                    decProfitMin = Convert.ToDecimal(ProfitMin);
                }
                catch
                {
                    //adding error message for viewbag
                    @ViewBag.Message = ProfitMin + "is not a valid number. Please try again.";

                }
                decProfitMin = Convert.ToDecimal(ProfitMin);

                query = query.Where(r => (r.Book.AvgSellingPrice - r.Book.AvgBookCost) >= decProfitMin);
            }

            if (!string.IsNullOrEmpty(ProfitMax))
            {
                decimal decPMax;

                try
                {
                    decPMax = Convert.ToDecimal(ProfitMax);
                }
                catch
                {
                    //adding error message for viewbag
                    @ViewBag.Message = ProfitMin + "is not a valid number. Please try again.";

                }
                //query = query.Where(r => r.Price >= decPMax);
                decPMax = Convert.ToDecimal(ProfitMax);
                query = query.Where(r => (r.Book.AvgSellingPrice - r.Book.AvgBookCost) <= decPMax);

            }

            if (!string.IsNullOrEmpty(PriceMin))
            {
                decimal decProfitMin;

                try
                {
                    decProfitMin = Convert.ToDecimal(PriceMin);
                }
                catch
                {
                    //adding error message for viewbag
                    @ViewBag.Message = ProfitMin + "is not a valid number. Please try again.";

                }
                //query = query.Where(r => r.Price >= decProfitMin);
                decProfitMin = Convert.ToDecimal(PriceMin);
                query = query.Where(r => r.BookPrice >= decProfitMin);

            }

            if (!string.IsNullOrEmpty(PriceMax))
            {
                decimal decPMax;

                try
                {
                    decPMax = Convert.ToDecimal(PriceMax);
                }
                catch
                {
                    //adding error message for viewbag
                    @ViewBag.Message = ProfitMin + "is not a valid number. Please try again.";

                }
                //query = query.Where(r => r.Price >= decPMax);
                decPMax = Convert.ToDecimal(PriceMax);
                query = query.Where(r => r.BookPrice <= decPMax);

            }

            BooksReport = query.Include(z => z.Book)
                                .ThenInclude(z => z.ProcurementDetails)
                                .Include(z => z.Order)
                                .ThenInclude(z => z.Customer).ToList();

            foreach (OrderDetail od in BooksReport)
            {
                AllBooksReportViewModel brvm = new AllBooksReportViewModel();

                brvm.Title = od.Book.Title;
                brvm.BookQuantity = od.BookQuantity;
                brvm.OrderNumber = od.Order.OrderNumber;
                brvm.CustomerName = od.Order.Customer.FirstName + ' ' + od.Order.Customer.LastName;
                brvm.SellingPrice = od.BookPrice;
                
                brvm.WeightedAvgCost = (decimal)od.Book.AvgBookCost;
                brvm.ProfitMargin = ((decimal)(brvm.SellingPrice - od.Book.AvgBookCost));
                brvm.OrderDate = od.Order.OrderDate;
                allBooksReports.Add(brvm);
            }

            ViewBag.SelectedRecords = allBooksReports.Count();

            switch (SelectedSort)
            {
                case SortReport.MostPopular: return View("AllBooksSold", allBooksReports.OrderByDescending(r => r.BookQuantity));
                case SortReport.MostRecent: return View("AllBooksSold", allBooksReports.OrderByDescending(r => r.OrderNumber));
                case SortReport.PriceAsc: return View("AllBooksSold", allBooksReports.OrderBy(r => r.SellingPrice));
                case SortReport.PriceDesc: return View("AllBooksSold", allBooksReports.OrderByDescending(r => r.SellingPrice));
                case SortReport.ProfitMarginAsc: return View("AllBooksSold", allBooksReports.OrderBy(r => r.ProfitMargin));
                case SortReport.ProfitMarginDesc: return View("AllBooksSold", allBooksReports.OrderByDescending(r => r.ProfitMargin));

            }
            return View("AllBooksSold", allBooksReports);


        }




        /// <All Order>
       
        [Authorize(Roles = "Admin")]
        public IActionResult SortSelectionB()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult AllOrders(SortReport SelectedSort, String ProfitMin, String ProfitMax, String PriceMin, String PriceMax)
        {

            //initialize booksreport viewmodel
            List<OrderReportVM> allBooksReports = new List<OrderReportVM>();

            List<OrderDetail> OrdersReport = new List<OrderDetail>();
            var query = from r in _db.OrderDetails select r;


            if (!string.IsNullOrEmpty(ProfitMin))
            {
                decimal decProfitMin;

                try
                {
                    decProfitMin = Convert.ToDecimal(ProfitMin);
                }
                catch
                {
                    
                    @ViewBag.Message = ProfitMin + "is not a valid number. Please try again.";

                }
                decProfitMin = Convert.ToDecimal(ProfitMin);
                //query = query.Where(r => r.Price >= decProfitMin);
                query = query.Where(r => (r.Book.AvgSellingPrice - r.Book.AvgBookCost) >= decProfitMin);
            }

            if (!string.IsNullOrEmpty(ProfitMax))
            {
                decimal decPMax;

                try
                {
                    decPMax = Convert.ToDecimal(ProfitMax);
                }
                catch
                {
                    //adding error message for viewbag
                    @ViewBag.Message = ProfitMin + "is not a valid number. Please try again.";

                }
                //query = query.Where(r => r.Price >= decPMax);
                decPMax = Convert.ToDecimal(ProfitMax);
                query = query.Where(r => (r.Book.AvgSellingPrice - r.Book.AvgBookCost) <= decPMax);

            }

            if (!string.IsNullOrEmpty(PriceMin))
            {
                decimal decProfitMin;

                try
                {
                    decProfitMin = Convert.ToDecimal(PriceMin);
                }
                catch
                {
                    //adding error message for viewbag
                    @ViewBag.Message = ProfitMin + "is not a valid number. Please try again.";

                }
                //query = query.Where(r => r.Price >= decProfitMin);
                decProfitMin = Convert.ToDecimal(PriceMin);
                query = query.Where(r => r.BookPrice >= decProfitMin);

            }

            if (!string.IsNullOrEmpty(PriceMax))
            {
                decimal decPMax;

                try
                {
                    decPMax = Convert.ToDecimal(PriceMax);
                }
                catch
                {
                    //adding error message for viewbag
                    @ViewBag.Message = ProfitMin + "is not a valid number. Please try again.";

                }
                //query = query.Where(r => r.Price >= decPMax);
                decPMax = Convert.ToDecimal(PriceMax);
                query = query.Where(r => r.BookPrice <= decPMax);

            }

            OrdersReport = query.ToList();

            List<Order> allOrders = new List<Order>();
            var orderquery = _db.Orders.Include(o => o.Customer).Include(o => o.OrderDetails).ThenInclude(o => o.Book).ThenInclude(o => o.ProcurementDetails);
            allOrders = orderquery.ToList();

            foreach (Order order in allOrders)
            {
                OrderReportVM orvm = new OrderReportVM();
                List<string> ListBookTandQ = new List<string>();
                decimal OrderRev = 0;
                decimal OrderCost = 0;
                decimal OrderProcQuantity = 0;

                int OrderQuantity = 0;

                string BookTitle;
                int BookQ;
                string TandQ;
                foreach (OrderDetail od in OrdersReport)
                {
                    int intTotalProc = od.Book.InitialInventory;
                    decimal decTotalCost = od.Book.InitialCost * od.Book.InitialInventory;

                    foreach (ProcurementDetail pro in od.Book.ProcurementDetails)
                    {
                        intTotalProc += pro.Quantity;
                        decTotalCost += pro.Book.Price * pro.Quantity;
                    }

                    if (od.Order.OrderID == order.OrderID)
                    {
                        OrderRev += od.SumPrice;
                        BookTitle = od.Book.Title;
                        BookQ = od.BookQuantity;
                        TandQ = BookTitle + " (" + BookQ.ToString() + ") ";
                        ListBookTandQ.Add(TandQ);
                        OrderCost += decTotalCost;
                        OrderProcQuantity += intTotalProc;
                        orvm.OrderDate = od.Order.OrderDate;
                        OrderQuantity += od.BookQuantity;
                    }

                }



        
                orvm.OrderNumber = order.OrderNumber;
                if (OrderProcQuantity == 0) { OrderProcQuantity = 1; }
                orvm.OrderCostAvg = (OrderCost / OrderProcQuantity);

                decimal OrderCostAvgTimesOrderQuantity = (OrderCost / OrderProcQuantity) * OrderQuantity;
                orvm.OrderCost = OrderCostAvgTimesOrderQuantity;
                orvm.ProfitMargin = (OrderRev - OrderCostAvgTimesOrderQuantity);


                orvm.BookTandQ = ListBookTandQ;
                orvm.OrderTotal = OrderRev;

                orvm.ProfitMarginMinusAvg = OrderRev - (OrderCost / OrderProcQuantity);

                if (orvm.OrderTotal != 0)
                {
                    allBooksReports.Add(orvm);
                }

            }


            ViewBag.SelectedRecords = allBooksReports.Count();

            switch (SelectedSort)
            {
                case SortReport.MostRecent: return View("AllOrders", allBooksReports.OrderByDescending(r => r.OrderNumber));
                case SortReport.PriceAsc: return View("AllOrders", allBooksReports.OrderBy(r => r.OrderTotal));
                case SortReport.PriceDesc: return View("AllOrders", allBooksReports.OrderByDescending(r => r.OrderTotal));
                case SortReport.ProfitMarginAsc: return View("AllOrders", allBooksReports.OrderBy(r => r.ProfitMargin));
                case SortReport.ProfitMarginDesc: return View("AllOrders", allBooksReports.OrderByDescending(r => r.ProfitMargin));

            }
            return View("AllOrders", allBooksReports);


        }


        //All Customer

        [Authorize(Roles = "Admin")]
        public IActionResult SortSelectionC()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> AllCustomers(SortReport SelectedSort)
        {
            List<CustomerReportVM> customerReportVMs = new List<CustomerReportVM>();

            List<OrderDetail> CustomersReports = new List<OrderDetail>();
            var query = _db.OrderDetails.Include(o => o.Book).ThenInclude(o => o.ProcurementDetails).Include(o => o.Order).ThenInclude(o => o.Customer);
            CustomersReports = query.ToList();

            List<AppUser> customers = new List<AppUser>();
            List<AppUser> members = new List<AppUser>();
            List<AppUser> nonMembers = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                var cuslist = await _userManager.IsInRoleAsync(user, "Customer") ? members : nonMembers;
                cuslist.Add(user);
            }
            RoleEditModel re = new RoleEditModel();
            re.Members = members;

            foreach (AppUser user in members)
            {

                CustomerReportVM crvm = new CustomerReportVM();
                List<string> ListBookTandQ = new List<string>();
                List<string> ListOrderNumbers = new List<string>();
                decimal CustomerProfit = 0;
                decimal CustomerCost = 0;
                string BookTitle;
                int BookQ;
                string TandQ;
                string strOrderNum;

                foreach (OrderDetail od in CustomersReports)
                {
                    if (od.Order.Customer.Id == user.Id)
                    {
                        CustomerProfit += od.SumPrice;
                        CustomerCost += (Decimal)od.Book.AvgBookCost;
                        strOrderNum = "{" + od.Order.OrderNumber.ToString() + "} ";
                        BookTitle = od.Book.Title;
                        BookQ = od.BookQuantity;
                        TandQ = BookTitle + " (" + BookQ.ToString() + ") ";
                        ListBookTandQ.Add(TandQ);
                        ListOrderNumbers.Add(strOrderNum);
                        crvm.CustomerName = od.Order.Customer.FirstName + ' ' + od.Order.Customer.LastName;
                    }
                }
                if (CustomerCost > 0 && CustomerProfit > 0)
                {
                    crvm.OrderNumbers = ListOrderNumbers;
                    crvm.ProfitMargin = (CustomerProfit - CustomerCost);
                    crvm.BookTandQ = ListBookTandQ;
                    crvm.CustomerTotal = CustomerProfit;
                    crvm.CustomerBooksCost = CustomerCost;

                    customerReportVMs.Add(crvm);
                }
            }

            ViewBag.SelectedRecords = customerReportVMs.Count();

            switch (SelectedSort)
            {
                case SortReport.PriceAsc: return View("AllCustomers", customerReportVMs.OrderBy(r => r.CustomerTotal));
                case SortReport.PriceDesc: return View("AllCustomers", customerReportVMs.OrderByDescending(r => r.CustomerTotal));
                case SortReport.ProfitMarginAsc: return View("AllCustomers", customerReportVMs.OrderBy(r => r.ProfitMargin));
                case SortReport.ProfitMarginDesc: return View("AllCustomers", customerReportVMs.OrderByDescending(r => r.ProfitMargin));

            }
            return View("AllCustomers", customerReportVMs);
        }


        //GET:Report D (totals)
        [Authorize(Roles = "Admin")]
        public ActionResult Totals()
        {
            List<OrderDetail> SelectedOrders = new List<OrderDetail>();
            var query = from o in _db.OrderDetails select o;
            query = query.Include(o => o.Order).Include(o => o.Book).ThenInclude(o => o.ProcurementDetails);
            SelectedOrders = query.ToList();

            List<Order> allOrders = new List<Order>();
            var oquery = from o in _db.Orders select o;
            oquery = oquery.Include(o => o.OrderDetails).ThenInclude(o => o.Book).ThenInclude(o => o.ProcurementDetails);
            allOrders = oquery.ToList();

            List<ProcurementDetail> ProcurementsReport = new List<ProcurementDetail>();
            var pquery = _db.ProcurementDetails.Include(o => o.Book).ThenInclude(o => o.OrderDetails).ThenInclude(o => o.Order).ThenInclude(o => o.Customer);
            ProcurementsReport = pquery.ToList();

            decimal TotalCost = 0;
            decimal TotalProfit = 0;
            decimal TotalRevenue = 0;
            int TotalQuant = 0;

            foreach (Order order in allOrders)
            {
                foreach (OrderDetail od in order.OrderDetails)
                {
                    TotalRevenue += (od.BookQuantity * od.BookPrice);
                    TotalQuant += od.BookQuantity;
                    TotalCost += ((Decimal)od.Book.AvgBookCost * od.BookQuantity);

                }
            }
            TotalProfit = TotalRevenue - TotalCost;



            ReportDVM rdvm = new ReportDVM();
            rdvm.TC = TotalCost;
            rdvm.TP = TotalProfit;
            rdvm.TR = TotalRevenue;

            return View(rdvm);
        }

        //Get Report E 
        [Authorize(Roles = "Admin")]
        public ActionResult CurrentInventory()
        {
            List<Book> InventoryList = new List<Book>();
            var query = from b in _db.Books select b;
            query = query.Where(b => b.Inventory > 0);
            query = query.Include(b => b.ProcurementDetails);
            InventoryList = query.ToList();
            ViewBag.SelectedRecords = InventoryList.Count();


            List<InventoryReportVM> inventoryReportVMs = new List<InventoryReportVM>();
            decimal TotalValueSold = 0;
            decimal TotalValueCost = 0;
            foreach (Book book in InventoryList)
            {
                InventoryReportVM irvm = new InventoryReportVM();
                irvm.Title = book.Title;
                irvm.BooksInInventory = book.Inventory;
                irvm.WeightedAvgCost = (decimal)book.AvgBookCost;
                TotalValueSold += (book.Inventory * (Decimal)book.AvgSellingPrice);
                TotalValueCost += (book.Inventory * (Decimal)book.AvgBookCost);
                inventoryReportVMs.Add(irvm);
            }

            ViewBag.TotalCost = TotalValueCost;
            ViewBag.TotalValue = TotalValueSold;

            return View("CurrentInventory", inventoryReportVMs);
        }

       
    }
}
   