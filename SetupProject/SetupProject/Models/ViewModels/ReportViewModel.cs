using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SetupProject.Models.ViewModels
{
    public class BookViewModel
    {
        public String Title { get; set; }

        public Int32 Quantity { get; set; }

        public Int32 OrderNumber { get; set; }

        public String Customer { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal SellingPrice { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal WeightedAvgCost { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal ProfitMargin { get; set; }

        public IEnumerable<AppUser> Customers { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }

    public class OrderViewModel
    {
        public String Title { get; set; }

        public Int32 Quantity { get; set; }

        public Int32 OrderNumber { get; set; }

        public String Customer { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal SellingPrice { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal WeightedAvgCost { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal ProfitMargin { get; set; }

        public IEnumerable<AppUser> Customers { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }

    public class CustomerViewModel
    {
        public String Title { get; set; }

        public Int32 Quantity { get; set; }

        public Int32 OrderNumber { get; set; }

        public String Customer { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal SellingPrice { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal WeightedAvgCost { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal ProfitMargin { get; set; }

        public IEnumerable<AppUser> Customers { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }

    public class TotalViewModel
    {
        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal TotalProfit { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal TotalCost { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal TotalRevenue { get; set; }

        public IEnumerable<AppUser> Customers { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }

    public class InventoryViewModel
    {
        public String Title { get; set; }

        public Int32 Quantity { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal WeightedAvgCost { get; set; }

        public IEnumerable<AppUser> Customers { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
