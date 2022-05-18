using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SetupProject.Models
{
    public class Book
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



        [Display(Name = "Average Sales Price")]
        public Decimal? AvgSellingPrice
        {
            get
            {
                if (OrderDetails.Count() == 0)
                {
                    return Price;
                }
                else
                {
                    decimal decAvgSalesPrice;
                    int allQuantity = InitialInventory;
                    decimal decPrice = InitialSellingPrice;

                    foreach (OrderDetail od in OrderDetails)
                    {
                        if (od.Book.BookID == BookID)
                        {
                            decPrice += (od.BookPrice * od.BookQuantity);
                            allQuantity += od.BookQuantity;
                        }
                    }

                    decAvgSalesPrice = (decPrice / allQuantity);
                    decAvgSalesPrice = Math.Round(decAvgSalesPrice, 2);
                    return decAvgSalesPrice;
                }
            }
        }

        [Display(Name = "Average Profit Margin")]
        public decimal? AvgProfitMargin => AvgSellingPrice - AvgBookCost;
  //      public void CalcProfitMargin()
    //    {
      //      AvgProfitMargin = (AvgSellingPrice - AvgBookCost);
        //}




        //Cost
        [Display(Name = "Cost")]
        public Decimal Cost { get; set; }

        [Display(Name = "Initial Cost")]
        public Decimal InitialCost { get; set; }



      
        [Display(Name = "Average Book Cost")]
        public Decimal? AvgBookCost
        {
            get
            {
                if(ProcurementDetails.Count() == 0)
                {
                    return Cost;
                }
                else
                {
                    decimal decAvgCost;
                    int allQuantity = InitialInventory;
                    decimal decCost = InitialCost * InitialInventory;

                    foreach (ProcurementDetail pr in ProcurementDetails)
                    {
                        if (pr.Book.BookID == BookID)
                        {
                            decCost += (pr.OrderCost*pr.Quantity);
                            allQuantity += pr.Quantity;
                        }
                    }
                    decAvgCost = (decCost / allQuantity);
                    decAvgCost = Math.Round(decAvgCost, 2);
                    return decAvgCost;
                }
            }
        }



       



        [Display(Name = "Average Rating")]
        public Decimal? AverageRating
        {
            get
            {
                if (Reviews.Count() == 0)
                {
                    return 0.0m;
                }
                else
                {
                    List<Review> ApprovedReviews = new List<Review>();
                    foreach (Review item in Reviews)
                    {
                        if (item.ApprovalStatus == ApprovalStatus.Yes && item.Description != null)
                        {
                            ApprovedReviews.Add(item);
                        }
                            
                    }
                    if (ApprovedReviews.Count() == 0)
                    {
                        return 0.0m;
                    }
                    else
                    {
                        Decimal avgrating = (decimal)ApprovedReviews.Average(m => m.Rating);
                        avgrating = Math.Round(avgrating, 1);
                        return avgrating;
                    }

                }
            }
        }






        [Display(Name = "Replenish Minimum")]
        public Int32 ReplenishMinimum { get; set; }

        [Display(Name = "Discontinued?")]
        public Boolean Discontinued { get; set; }



        public Genre Genre { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Review> Reviews { get; set; }
        public List <ProcurementDetail> ProcurementDetails { get; set; }

        public Book()
        {
            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }

            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }

            if (ProcurementDetails == null)
            {
                ProcurementDetails = new List<ProcurementDetail>();
            }
        }

    }
}
