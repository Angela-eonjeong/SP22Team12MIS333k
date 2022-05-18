using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SetupProject.Models
{

    public enum CouponType { FreeShipping, Percent }
    public class Promotion
    { 
        public Int32 PromotionID { get; set; }

        [Display(Name = "Promotion Code:")]
        [StringLength(20, ErrorMessage = "20 characters max")]
        public String PromoCode { get; set; }

        [Display(Name = "Promotion Description:")]
        public String PromoDescription { get; set; }

        public Decimal DiscountAmount { get; set; }
        public Boolean ShipWaiver { get; set; }
        public Decimal MinimumSpend { get; set; }

        [Display(Name = "Promotion Status:")]
        public Boolean Status { get; set; }

        public List<Order> Orders { get; set; }

        public Promotion()
        {
            if (Orders == null)
            {
                Orders = new List<Order>();
            }
        }
    }
}
