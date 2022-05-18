
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SetupProject.Models
{
    public class ProcurementVM
    {
        [Display(Name = "Book ID")]
        public Int32 BookID { get; set; }

        [Display(Name = "Unique Number")]
        public Int32 UniqueNumber { get; set; }

        [Display(Name = "Title")]
        public String Title { get; set; }

        [Display(Name = "Author")]
        public String Author { get; set; }

        [Display(Name = "Publish Date")]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }

        [Display(Name = "Last Ordered")]
        [DataType(DataType.Date)]
        public DateTime LastOrdered { get; set; }

        [Display(Name = "Book Description")]
        public String Description { get; set; }

        //Inventory
        [Display(Name = "Inventory")]
        public Int32 Inventory { get; set; }

        [Display(Name = "Initial Inventory")]
        public Int32 InitialInventory { get; set; }

        //Selling price
        [Display(Name = "Selling Price")]
        public Decimal Price { get; set; }

        [Display(Name = "Initial Selling Price")]
        public Decimal InitialSellingPrice { get; set; }



        



        //Cost
        [Display(Name = "Cost")]
        public Decimal Cost { get; set; }

        [Display(Name = "Initial Cost")]
        public Decimal InitialCost { get; set; }






        [Display(Name = "Replenish Minimum")]
        public Int32 ReplenishMinimum { get; set; }

        [Display(Name = "Discontinued?")]
        public Boolean Discontinued { get; set; }



        public AppUser Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Book> Books { get; set; }
        public List<ProcurementDetail> ProcurementDetails { get; set; }

        
    }
}

