using SetupProject.DAL;
using SetupProject.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SetupProject.Seeding
{
	public static class SeedOrderDetails
	{
		public static void SeedAllOrderDetails(AppDbContext db)
		{
			Int32 intOrderDetailsAdded = 0;
			String strDescription = "Begin";
			//Add the list of OrderDetails
			List<OrderDetail> OrderDetails = new List<OrderDetail>();
				OrderDetail b1 = new OrderDetail()
				{
					BookQuantity = 3,
				};
				b1.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222001);
				b1.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222232);
				OrderDetails.Add(b1);

				OrderDetail b2 = new OrderDetail()
				{
					BookQuantity = 3,
				};
				b2.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222002);
				b2.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222112);
				OrderDetails.Add(b2);

				OrderDetail b3 = new OrderDetail()
				{
					BookQuantity = 4,
				};
				b3.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222002);
				b3.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222292);
				OrderDetails.Add(b3);

				OrderDetail b4 = new OrderDetail()
				{
					BookQuantity = 3,
				};
				b4.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222002);
				b4.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222062);
				OrderDetails.Add(b4);

				OrderDetail b5 = new OrderDetail()
				{
					BookQuantity = 2,
				};
				b5.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222002);
				b5.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222125);
				OrderDetails.Add(b5);

				OrderDetail b6 = new OrderDetail()
				{
					BookQuantity = 2,
				};
				b6.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222003);
				b6.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222221);
				OrderDetails.Add(b6);

				OrderDetail b7 = new OrderDetail()
				{
					BookQuantity = 1,
				};
				b7.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222003);
				b7.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222133);
				OrderDetails.Add(b7);

				OrderDetail b8 = new OrderDetail()
				{
					BookQuantity = 3,
				};
				b8.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222003);
				b8.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222065);
				OrderDetails.Add(b8);

				OrderDetail b9 = new OrderDetail()
				{
					BookQuantity = 1,
				};
				b9.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222004);
				b9.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222202);
				OrderDetails.Add(b9);

				OrderDetail b10 = new OrderDetail()
				{
					BookQuantity = 1,
				};
				b10.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222004);
				b10.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222003);
				OrderDetails.Add(b10);

				OrderDetail b11 = new OrderDetail()
				{
					BookQuantity = 1,
				};
				b11.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222005);
				b11.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222058);
				OrderDetails.Add(b11);

				OrderDetail b12 = new OrderDetail()
				{
					BookQuantity = 3,
				};
				b12.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222005);
				b12.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222278);
				OrderDetails.Add(b12);

				OrderDetail b13 = new OrderDetail()
				{
					BookQuantity = 4,
				};
				b13.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222005);
				b13.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222064);
				OrderDetails.Add(b13);

				OrderDetail b14 = new OrderDetail()
				{
					BookQuantity = 3,
				};
				b14.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222005);
				b14.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222208);
				OrderDetails.Add(b14);

				OrderDetail b15 = new OrderDetail()
				{
					BookQuantity = 3,
				};
				b15.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222006);
				b15.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222272);
				OrderDetails.Add(b15);

				OrderDetail b16 = new OrderDetail()
				{
					BookQuantity = 1,
				};
				b16.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222006);
				b16.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222121);
				OrderDetails.Add(b16);

				OrderDetail b17 = new OrderDetail()
				{
					BookQuantity = 1,
				};
				b17.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222006);
				b17.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222040);
				OrderDetails.Add(b17);

				OrderDetail b18 = new OrderDetail()
				{
					BookQuantity = 1,
				};
				b18.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222006);
				b18.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222297);
				OrderDetails.Add(b18);

				OrderDetail b19 = new OrderDetail()
				{
					BookQuantity = 4,
				};
				b19.Order = db.Orders.FirstOrDefault(g => g.OrderNumber == 222007);
				b19.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222081);
				OrderDetails.Add(b19);

			try
			{
				foreach (OrderDetail OrderDetailToAdd in OrderDetails)
				{
					int OrderDetailID = OrderDetailToAdd.OrderDetailID;
					OrderDetail dbOrderDetail = db.OrderDetails.FirstOrDefault(b => b.OrderDetailID == OrderDetailToAdd.OrderDetailID);
					if (dbOrderDetail == null)
					{
						db.OrderDetails.Add(OrderDetailToAdd);
						db.SaveChanges();
						intOrderDetailsAdded += 1;
					}
					else
					{
						dbOrderDetail.Book = OrderDetailToAdd.Book;
						dbOrderDetail.Order = OrderDetailToAdd.Order;
						dbOrderDetail.BookQuantity = OrderDetailToAdd.BookQuantity;
						db.Update(dbOrderDetail);
						db.SaveChanges();
						intOrderDetailsAdded += 1;
					}
				}
			}
			catch (Exception ex)
			{
				String msg = "Repositories added:"+ intOrderDetailsAdded +"; Error on "+ strDescription;
				throw new InvalidOperationException(ex.Message + msg);
			}
		}
	}
}
