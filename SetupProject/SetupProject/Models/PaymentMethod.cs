using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SetupProject.Models
{
    public class PaymentMethod
    {
        public Int32 PaymentMethodID {get; set;}

        [Display(Name = "Card Number:")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Credit card number must be 16 digits")]
        
        public String CardNumber { get; set; }

        [Display(Name = "Card Type:")]

        public String CardType { get; set; }

        public AppUser Customer { get; set; }
       
    }
}
