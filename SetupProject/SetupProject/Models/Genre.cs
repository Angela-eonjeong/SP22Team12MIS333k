using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SetupProject.Models
{
    public class Genre
    {
        [Display(Name = "Genre ID")]
        public Int32 GenreID { get; set; }

        [Display(Name = "Genre")]
        public String GenreName { get; set; }

        //Nav Property
        public List<Book> Books  { get; set; }

        public Genre()
        {
            if (Books == null)
            {
                Books = new List<Book>();
            }
        }

    }
}
