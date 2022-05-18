using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SetupProject.Models
{ 
    public enum CompleteStatus { Complete, InComplete, Cancelled}

    public class Order
    {
        public CompleteStatus CompleteStatus { get; set; }

        [Display(Name = "Order ID:")]
        public Int32 OrderID { get; set; }

        [Display(Name = "Order Number:")]
        public Int32 OrderNumber { get; set; }


        [Display(Name = "Order Date:")]
        [DisplayFormat(DataFormatString = "{0:MM.dd.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Order SubTotal:")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public Decimal OrderSubtotal
        {
            get { return OrderDetails.Sum(od => od.SumPrice); }
        }

        [Display(Name = "Shipping Cost:")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public Decimal ShippingCost { get; set; }

        [Display(Name = "Order Total:")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public Decimal OrderTotal
        {
            get
            {
                return OrderSubtotal + ShippingCost;
            }
        }

        // Can have many order details
        public List<OrderDetail> OrderDetails { get; set; }

        // Can have one promotion
        public Promotion Promotion { get; set; }

        // Associated with one User 
        public AppUser Customer { get; set; }

        public Order()
        {
            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }
        }

      

    }
}

