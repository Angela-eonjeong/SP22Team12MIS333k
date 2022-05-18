using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SetupProject.Models
{
    public class ProcurementDetail
    {
        public Int32 ProcurementDetailID { get; set; }

        [Display(Name = "Order Quantity:")]
        [Range(0, 1000, ErrorMessage = "Number of products cannot be negative")]
        public Int16 Quantity { get; set; }

        [Display(Name = "Order Cost:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderCost { get; set; }

       
      

        public ProcurementOrder ProcurementOrder { get; set; }
        public Book Book { get; set; }
    }
}
