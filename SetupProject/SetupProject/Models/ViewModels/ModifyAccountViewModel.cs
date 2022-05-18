using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SetupProject.Models
{
    public class ModifyAccountViewModel
    {
        public String Id { get; set; }

        [Display(Name = "Email Address")]
        public String EmailAddress { get; set; }


        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        
        [Display(Name = "Address")]
        public String Address { get; set; }

        [Display(Name = "City")]
        public String City { get; set; }

        [Display(Name = "State")]
        public String State { get; set; }

        [Display(Name = "Zip")]
        public String Zip { get; set; }

        [Display(Name = "Phone Number")]
        public String PhoneNumber { get; set; }


        [DataType(DataType.CreditCard)]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Credit card number must be 16 digits")]
        [Display(Name = "Credit Card 1")]
        public String CreditCard1 { get; set; }

        [DataType(DataType.CreditCard)]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Credit card number must be 16 digits")]
        [Display(Name = "Credit Card 2")]
        public String CreditCard2 { get; set; }

        [DataType(DataType.CreditCard)]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Credit card number must be 16 digits")]
        [Display(Name = "Credit Card 3")]
        public String CreditCard3 { get; set; }

    }
}
