using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SetupProject.DAL;
using SetupProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace SetupProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProcurementOrdersController : Controller
    {
        private readonly AppDbContext _context;



        public ProcurementOrdersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProcurementOrders.Include(p => p.ProcurementDetails).ThenInclude(p => p.Book).Where(r => r.Status == false).ToListAsync());
        }




        //SEARCH INDEX
        public IActionResult Search(String SearchString)
        {

            var query = from b in _context.Books select b;

            if (string.IsNullOrEmpty(SearchString) == false)
            {
                query = query.Where(b => b.Title.Contains(SearchString) || b.Description.Contains(SearchString));
            }

            List<Book> SelectedBooks = query.Include(b => b.Genre).Include(b => b.Reviews).ToList();

            ViewBag.OutOfStock = "Out of stock.";
            ViewBag.InStock = "In Stock!";
            ViewBag.AllBooks = _context.Books.Count();
            ViewBag.SelectedBooks = SelectedBooks.Count;

            return View(SelectedBooks.OrderBy(s => s.Title));
        }




        // GET: CREATEMANUAL
        public IActionResult CreateManual(int id)
        {

            //Create a new instance of the OrderDetail class
            ProcurementDetail od = new ProcurementDetail();

            Book book = _context.Books.FirstOrDefault(b => b.BookID == id); //check if null
            //Set the new order detail's course equal to the order you just found
            od.Book = book;
            

            return View(od);
        }







        // POST: CREATEMANUAL  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateManual(ProcurementDetail procurementDetail)
        {
            if (ModelState.IsValid == false)
            {

                return View(procurementDetail);
            }

            Book dbBook = _context.Books.Find(procurementDetail.Book.BookID);
            procurementDetail.Book = dbBook;
            ProcurementOrder procurementOrder = _context.ProcurementOrders
                                                .Include( po => po.ProcurementDetails)
                                                .ThenInclude(po => po.Book)
                                                .Include(po => po.Manager)
                                                .Where(po => po.Manager.UserName == User.Identity.Name)
                                                .FirstOrDefault();
            if (procurementOrder is null)
            {
                procurementOrder = new ProcurementOrder();
                procurementOrder.ProcurementDate = DateTime.Today;
                _context.Add(procurementOrder);
                await _context.SaveChangesAsync();
            }
            procurementDetail.ProcurementOrder = procurementOrder;
            

            




            
            procurementDetail.Quantity = procurementDetail.Quantity;
            procurementDetail.OrderCost = procurementDetail.OrderCost;
            
            
           // dbBook.Cost = procurementDetail.OrderCost;
           
            
            _context.Add(procurementDetail);
           // procurementDetail.Quantity = procurementOrder.QuantityToAdd;
            //Add the order detail to the database
            _context.Update(procurementOrder);
            await _context.SaveChangesAsync();

            //send the user to the details page for this order
            //return RedirectToAction("Details", new { id = procurementDetail.Book.BookID });
            return RedirectToAction("Details", new { procurementOrderID = procurementOrder.ProcurementOrderID });
        }







        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? procurementOrderID, int id)
        {
           
            if (procurementOrderID == null)
            {
                return View("Error", new String[] { "Please specify a order to view!" });
            }

            //Find the order in the database
            ProcurementOrder procurementOrder = await _context.ProcurementOrders
                 .Include(o => o.ProcurementDetails)
                 .ThenInclude(o => o.Book)
                 .FirstOrDefaultAsync(m => m.ProcurementOrderID == procurementOrderID);

            //Send the user to the details page 
            return View(procurementOrder);
        }






        // GET: ProcurementOrders/Create/AUTO
        //GET: Automatic Order
        
        public IActionResult AutoOrderDisplay()
        {
            var query = from r in _context.Books select r;
            
            query = query.Where(r => r.Inventory <= r.ReplenishMinimum);
            List<Book> ProcBook = query.ToList();
            return View(ProcBook);

        }

        [HttpPost]
        
        public IActionResult AutoOrderDisplay(int[] newid, string[] newquantity, Decimal Cost)
        {

            var query = from r in _context.Books select r;
            
            List<Book> allBooks = new List<Book>();
            allBooks = query.ToList();

            List<Book> SelectedBooks = new List<Book>();

            foreach (Book book in allBooks)
            {
                foreach (int id in newid)
                {
                    if (id == book.BookID) { SelectedBooks.Add(book); }
                }
            }

            Int16 Qt = Convert.ToInt16(newquantity);

            foreach (Book b in SelectedBooks)
            {
                ProcurementDetail procurementDetail = new ProcurementDetail();
                procurementDetail.OrderCost = Cost;
             
            }



            return View("Index", "ProcurementDetails");
        }




        public IActionResult CreateAuto(int[] newid)
        {
            var query = from r in _context.Books select r;
           
            List<Book> allBooks = new List<Book>();
            allBooks = query.ToList();

            List<Book> SelectedBooks = new List<Book>();

            foreach (Book book in allBooks)
            {
                foreach (int id in newid)
                {
                    if (id == book.BookID) { SelectedBooks.Add(book); }
                }
            }

            return View("ConfirmCart", SelectedBooks);
        }


        public ActionResult ConfirmCart()
        {
            return View();
        }

        // GET: ProcurementOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var procurementOrder = await _context.ProcurementOrders.FindAsync(id);
            if (procurementOrder == null)
            {
                return NotFound();
            }
            return View(procurementOrder);
        }

        // POST: ProcurementOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProcurementOrderID,ProcurementDate,Status")] ProcurementOrder procurementOrder)
        {
            if (id != procurementOrder.ProcurementOrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(procurementOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcurementOrderExists(procurementOrder.ProcurementOrderID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(procurementOrder);
        }

        // GET: ProcurementOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var procurementOrder = await _context.ProcurementOrders
                .FirstOrDefaultAsync(m => m.ProcurementOrderID == id);
            if (procurementOrder == null)
            {
                return NotFound();
            }

            return View(procurementOrder);
        }

        // POST: ProcurementOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var procurementOrder = await _context.ProcurementOrders.FindAsync(id);
            _context.ProcurementOrders.Remove(procurementOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcurementOrderExists(int id)
        {
            return _context.ProcurementOrders.Any(e => e.ProcurementOrderID == id);
        }




        
    }


}
