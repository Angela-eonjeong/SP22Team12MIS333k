using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SetupProject.Models
{
    public class ShippingCosts
    {
        [Display(Name = "Shipping Costs ID")]
        [Key]
        public Int32 ShippingCostsID { get; set; }

        [Display(Name = "First Book Shipping Cost")]

        public Decimal FirstBookShipCost { get; set; }

        [Display(Name = "Additional Book Shipping Cost")]
        public Decimal AddBookShipCost { get; set; }
    }
}
