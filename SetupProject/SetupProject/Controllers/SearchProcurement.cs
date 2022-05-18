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




namespace SetupProject.Controllers
{
    

    public class SearchProcurement : Controller
    {

        //Adding a constructor to get an instance of DbContext
        private AppDbContext _context;
        public SearchProcurement(AppDbContext dbContext)
        {
            _context = dbContext;
        }

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






        //Details -- pg 8 of HW 3
        public IActionResult Details(int? id)//id is the id of the movie you want to see
        {
            if (id == null) //BookID not specified
            {
                //user did not specify a BookID – take them to the error view
                return View("Error", new String[] { "BookID not specified - which book do you want to view?" });
            }
            //look up the book in the database based on the id; be sure to include the genre

            Book book = _context.Books.Include(b => b.Genre).FirstOrDefault(b => b.BookID == id);

            if (book == null) //No Book with this id exists in the database
            {
                //there is not a book with this id in the database – show an error view
                return View("Error", new String[] { "Book not found in database" });
            }
            //if code gets this far, all is well – display the details
            return View(book);

        }

        //DetailedSearch
        public IActionResult DetailedSearch()
        {
            ViewBag.AllGenres = GetAllGenres();

            SearchViewModel svm = new SearchViewModel();


            return View(svm);

        }

        //DropDownList for Genre
        private SelectList GetAllGenres()
        {
            //Get the list of months from the database
            List<Genre> Genres = _context.Genres.ToList();

            //add a dummy entry so the user can select all months
            Genre SelectNone = new Genre() { GenreID = 0, GenreName = "All Genres" };
            Genres.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList AllGenres = new SelectList(Genres.OrderBy(m => m.GenreID), "GenreID", "GenreName");

            //return the electList
            return AllGenres;
        }

        public ActionResult DisplaySearchResults(SearchViewModel svm, Sorting sort, InventorySort instock, int UserSelectedGenreID)
        {




            var query = from c in _context.Books select c;

            //Title
            if (svm.UserSelectedTitle != null && svm.UserSelectedTitle != "")
            {
                query = query.Where(c => c.Title.Contains(svm.UserSelectedTitle));
            }

            //Author
            if (svm.UserSelectedAuthor != null && svm.UserSelectedAuthor != "")
            {
                query = query.Where(c => c.Author.Contains(svm.UserSelectedAuthor));
            }

            //Unique Number
            if (svm.UserSelectedUniqueNumber != null)
            {
                query = query.Where(c => c.UniqueNumber == svm.UserSelectedUniqueNumber);
            }


            //Genre
            if (svm.UserSelectedGenreID != 0)
            {
                query = query.Where(c => c.Genre.GenreID == svm.UserSelectedGenreID);
            }

            //Inventory
            switch (instock)
            {
                case InventorySort.AllBooks:
                    break;
                case InventorySort.InStock:
                    query = query.Where(r => r.Inventory > 0);
                    break;
                default:
                    break;
            }


            List<Book> SelectedBooks = query.Include(c => c.Genre).Include(c => c.Reviews).ToList();

            ViewBag.OutOfStock = "Out of stock.";
            ViewBag.InStock = "In Stock!";
            ViewBag.AllBooks = _context.Books.Count();
            ViewBag.SelectedBooks = SelectedBooks.Count;



            switch (sort)
            {
                case Sorting.Title:
                    return View("Index", SelectedBooks.OrderBy(r => r.Title));
                case Sorting.Author:
                    return View("Index", SelectedBooks.OrderBy(r => r.Author));

                case Sorting.Newest:
                    return View("Index", SelectedBooks.OrderByDescending(r => r.PublishedDate));
                case Sorting.Oldest:
                    return View("Index", SelectedBooks.OrderBy(r => r.PublishedDate));
                case Sorting.Rating:
                    return View("Index", SelectedBooks.OrderByDescending(r => r.AverageRating));

                    //TODO: add more sorting stuff 
            }


            ViewBag.OutOfStock = "Out of stock.";
            ViewBag.InStock = "In Stock!";
            ViewBag.AllBooks = _context.Books.Count();
            ViewBag.SelectedBooks = SelectedBooks.Count;

            return View("Index", SelectedBooks);

        }






    }


}
