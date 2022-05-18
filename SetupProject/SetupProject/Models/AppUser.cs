using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


namespace SetupProject.Models
{
    public class AppUser :IdentityUser 
    {
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



        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [Display(Name = "User Status")]
        public string UserStatus { get; set; }


        public List<Order> Orders { get; set; }
        public List<Review> Reviews { get; set; }
        public List<PaymentMethod> PaymentMethods { get; set; }

        
        }


    
    
    }

    

