using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SetupProject.Models
{
    public class SearchViewModel
    {

        public Int32 SearchViewModelID { get; set; }

        //genre -- nav
        [Display(Name = "Search by Genre:")]
        public Int32? UserSelectedGenreID { get; set; }

        //title
        [Display(Name = "Search by Title:")]
        public String UserSelectedTitle { get; set; }


        //author
        [Display(Name = "Search by Author:")]
        public String UserSelectedAuthor { get; set; }

        //unique number
        [Display(Name = "Search by Unique Number:")]
        public Int32? UserSelectedUniqueNumber { get; set; }

        //in stock
        [Display(Name = "In Stock?")]
        public Boolean SelectedInStock { get; set; }

        //rating
        [Display(Name = "Search by Rating:")]
        public Decimal? UserSelectedRating { get; set; }

        //isdiscontinued
        [Display(Name = "Discontinued?")]
        public Boolean UserISDiscontinued { get; set; }

        [Display(Name = "Search by Description:")]
        public String UserSelectedDescription { get; set; }

        [Display(Name = "Total Times Ordered:")]
        public Int32 QuantityOrdered { get; set; }


        [Display(Name = "Published Date:")]
        public DateTime UserSelectedPublishedDate { get; set; }
        
        public IEnumerable<AppUser> Customers { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
