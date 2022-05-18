using SetupProject.DAL;
using SetupProject.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SetupProject.Seeding
{
    public static class SeedingDemo
    {
        public static void SeedOneBook(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intBooksAdded = 0;
            String strBookTitle = "Begin";

            //Add the list of books
            List<Book> Books = new List<Book>();
            Book b1 = new Book()
            {
                Title = "The Art Of Racing In The Rain",
                Author = "Garth Stein",
                Description = "A Lab-terrier mix with great insight into the human condition helps his owner, a struggling race car driver.",
                PublishedDate = new DateTime(2008, 5, 24),
                Price = 21.95m,

            };
            b1.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
            //Add this book to the list of books to add
            Books.Add(b1);

            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (Book bookToAdd in Books)
                {
                    //set the flag to the current title to help with debugging
                    strBookTitle = bookToAdd.Title;

                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    Book dbBook = db.Books.FirstOrDefault(b => b.Title == bookToAdd.Title);

                    //if the dbBook is null, this title is not in the database
                    if (dbBook == null)
                    {
                        //add the book to the database and save changes
                        db.Books.Add(bookToAdd);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intBooksAdded += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties
                        dbBook.Title = bookToAdd.Title;
                        dbBook.Author = bookToAdd.Author;
                        dbBook.PublishedDate = bookToAdd.PublishedDate;
                        dbBook.Description = bookToAdd.Description;
                        dbBook.Price = bookToAdd.Price;

                        //since we found the correct genre object in a previous step,
                        //this update is easy - both dbBook and bookToAdd have a Genre 
                        //object for this property
                        dbBook.Genre = bookToAdd.Genre;

                        //update the database and save the changes
                        db.Update(dbBook);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intBooksAdded += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                //Build a messsage using the flags we created
                String msg = "  Repositories added:" + intBooksAdded + "; Error on " + strBookTitle;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}

