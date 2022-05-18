using SetupProject.DAL;
using SetupProject.Models;
using SetupProject.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Authorization;


namespace SetupProject.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context;
        }

        //DropDownList for Genre
        private SelectList GetAllGenres()
        {
            //Get the list of months from the database
            List<Genre> allGenres = _context.Genres.ToList();

            //add a dummy entry so the user can select all months
            Genre NewGenre = new Genre() { GenreID = 0, GenreName = "All Genres" };
            allGenres.Add(NewGenre);

            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList GenreList = new SelectList(allGenres.OrderBy(m => m.GenreID), "GenreID", "GenreName");

            //return the electList
            return GenreList;
        }
        private SelectList GetAllGenres(Book book)
        {
            //create a list of all the suppliers
            List<Genre> allGenres = _context.Genres.ToList();

            //create the multiselect with the overload for currently selected items
            SelectList GenreList = new SelectList(allGenres, "GenreID", "GenreName", book.Genre.GenreID);

            //return the list
            return GenreList;
        }


        public IActionResult Index(String SearchString)
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









        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.Include(m => m.Genre).Include(r => r.Reviews)
                .FirstOrDefaultAsync(m => m.BookID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }





        // GET: Books/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create(int uniqueNumber)
        {

            ViewBag.AllGenres = GetAllGenres();

            return View();
        }


        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(Book book, int SelectedGenre)

        {

            book.Genre = _context.Genres.FirstOrDefault(b => b.GenreID == SelectedGenre);

            //make sure all properties are valid
            if (ModelState.IsValid == false)
            {
                ViewBag.AllGenres = GetAllGenres();
                return View(book);
            }

            book.UniqueNumber = Utilities.GenerateBookUniqueNumber.GetNextBookUniqueNumber(_context);

            //if code gets this far, add the book to the database
            _context.Add(book);
            await _context.SaveChangesAsync();


            //send the user to the details page for this order
            return RedirectToAction("Details", "Books", new { id = book.BookID });
        }
















        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.Include(c => c.Genre).FirstOrDefaultAsync(c => c.BookID == id);
            if (book == null)
            {
                return NotFound();
            }
            ViewBag.AllGenres = GetAllGenres(book);

            return View(book);
        }

        // POST: Books/Edit/5  //[Bind("BookID,UniqueNumber,Title, Author, PublishedDate, Description, Price, Cost, Inventory, ReplenishMinimum, Discontinued")] 
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Book book, int SelectedGenre)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Book dbBook = _context.Books.Include(c => c.Genre).FirstOrDefault(c => c.BookID == book.BookID);

                    //update the Title
                    dbBook.Title = book.Title;
                    //update the Author
                    dbBook.Author = book.Author;
                    //update the Published Date
                    dbBook.PublishedDate = book.PublishedDate;
                    //update the Description
                    dbBook.Description = book.Description;
                    //update the Price
                    dbBook.Price = book.Price;
                    //update the Cost
                    dbBook.Cost = book.Cost;
                    //update the Inventory
                    dbBook.Inventory = book.Inventory;
                    //update the replenishmin
                    dbBook.ReplenishMinimum = book.ReplenishMinimum;
                    //update the discountined
                    dbBook.Discontinued = book.Discontinued;

                    _context.Update(dbBook);
                    await _context.SaveChangesAsync();

                    Genre dbGenre = _context.Genres.Include(c => c.Books).FirstOrDefault(c => c.GenreID == SelectedGenre);
                    dbGenre.Books.Remove(book);
                    dbGenre.Books.Add(dbBook);
                    _context.Update(dbGenre);
                    _context.Update(dbBook);

                }

                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookID))
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
            ViewBag.AllGenres = GetAllGenres(book);
            return View(book);
        }
        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.BookID == id);
        }
    

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.BookID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        

        

    }
}
