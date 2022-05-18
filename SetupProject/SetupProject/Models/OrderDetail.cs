using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SetupProject.Models
{
    public class OrderDetail
    {
        public Int32 OrderDetailID { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Display(Name = "Quantity:")]
        [Range(1, 10000000000, ErrorMessage = "Number of products cannot be negative")]
        public Int32 BookQuantity { get; set; }

        [Display(Name = "Price:")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public Decimal BookPrice { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Sum Price")]
        public Decimal SumPrice
        {
            get { return BookQuantity * BookPrice; }
        }

        public Order Order { get; set; }
        public Book Book { get; set; }


    }
}
