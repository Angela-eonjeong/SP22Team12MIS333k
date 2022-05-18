using SetupProject.DAL;
using SetupProject.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SetupProject.Seeding
{
	public static class SeedOrders
	{
		public static void SeedAllOrders(AppDbContext db)
		{
			Int32 intOrdersAdded = 0;
			Int32 intOrderNumber = 222001;
			//Add the list of Orders
			List<Order> Orders = new List<Order>();
				Order b1 = new Order()
				{
					OrderNumber = 222001,
					OrderDate = new DateTime(2022, 3, 5),
				};
				b1.Customer = db.Users.FirstOrDefault(g => g.UserName == "erynrice@puppy.com");
				b1.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "HOOKEM50");
				Orders.Add(b1);

				Order b2 = new Order()
				{
					OrderNumber = 222002,
					OrderDate = new DateTime(2022, 3, 9),
				};
				b2.Customer = db.Users.FirstOrDefault(g => g.UserName == "limchou@puppy.com");
				b2.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "FREESHIPPING512");
				Orders.Add(b2);

				Order b3 = new Order()
				{
					OrderNumber = 222002,
					OrderDate = new DateTime(2022, 3, 9),
				};
				b3.Customer = db.Users.FirstOrDefault(g => g.UserName == "limchou@puppy.com");
				b3.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "FREESHIPPING512");
				Orders.Add(b3);

				Order b4 = new Order()
				{
					OrderNumber = 222002,
					OrderDate = new DateTime(2022, 3, 9),
				};
				b4.Customer = db.Users.FirstOrDefault(g => g.UserName == "limchou@puppy.com");
				b4.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "FREESHIPPING512");
				Orders.Add(b4);

				Order b5 = new Order()
				{
					OrderNumber = 222002,
					OrderDate = new DateTime(2022, 3, 9),
				};
				b5.Customer = db.Users.FirstOrDefault(g => g.UserName == "limchou@puppy.com");
				b5.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "FREESHIPPING512");
				Orders.Add(b5);

				Order b6 = new Order()
				{
					OrderNumber = 222003,
					OrderDate = new DateTime(2022, 3, 11),
				};
				b6.Customer = db.Users.FirstOrDefault(g => g.UserName == "limchou@puppy.com");
				b6.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "IfIFitsIShips");
				Orders.Add(b6);

				Order b7 = new Order()
				{
					OrderNumber = 222003,
					OrderDate = new DateTime(2022, 3, 11),
				};
				b7.Customer = db.Users.FirstOrDefault(g => g.UserName == "limchou@puppy.com");
				b7.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "IfIFitsIShips");
				Orders.Add(b7);

				Order b8 = new Order()
				{
					OrderNumber = 222003,
					OrderDate = new DateTime(2022, 3, 11),
				};
				b8.Customer = db.Users.FirstOrDefault(g => g.UserName == "limchou@puppy.com");
				b8.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "IfIFitsIShips");
				Orders.Add(b8);

				Order b9 = new Order()
				{
					OrderNumber = 222004,
					OrderDate = new DateTime(2022, 3, 13),
				};
				b9.Customer = db.Users.FirstOrDefault(g => g.UserName == "orielly@foxnets.com");
				b9.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "");
				Orders.Add(b9);

				Order b10 = new Order()
				{
					OrderNumber = 222004,
					OrderDate = new DateTime(2022, 3, 13),
				};
				b10.Customer = db.Users.FirstOrDefault(g => g.UserName == "orielly@foxnets.com");
				b10.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "");
				Orders.Add(b10);

				Order b11 = new Order()
				{
					OrderNumber = 222005,
					OrderDate = new DateTime(2022, 3, 17),
				};
				b11.Customer = db.Users.FirstOrDefault(g => g.UserName == "orielly@foxnets.com");
				b11.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "");
				Orders.Add(b11);

				Order b12 = new Order()
				{
					OrderNumber = 222005,
					OrderDate = new DateTime(2022, 3, 17),
				};
				b12.Customer = db.Users.FirstOrDefault(g => g.UserName == "orielly@foxnets.com");
				b12.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "");
				Orders.Add(b12);

				Order b13 = new Order()
				{
					OrderNumber = 222005,
					OrderDate = new DateTime(2022, 3, 17),
				};
				b13.Customer = db.Users.FirstOrDefault(g => g.UserName == "orielly@foxnets.com");
				b13.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "");
				Orders.Add(b13);

				Order b14 = new Order()
				{
					OrderNumber = 222005,
					OrderDate = new DateTime(2022, 3, 17),
				};
				b14.Customer = db.Users.FirstOrDefault(g => g.UserName == "orielly@foxnets.com");
				b14.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "");
				Orders.Add(b14);

				Order b15 = new Order()
				{
					OrderNumber = 222006,
					OrderDate = new DateTime(2022, 3, 21),
				};
				b15.Customer = db.Users.FirstOrDefault(g => g.UserName == "jorge@hootmail.com");
				b15.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "");
				Orders.Add(b15);

				Order b16 = new Order()
				{
					OrderNumber = 222006,
					OrderDate = new DateTime(2022, 3, 21),
				};
				b16.Customer = db.Users.FirstOrDefault(g => g.UserName == "jorge@hootmail.com");
				b16.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "");
				Orders.Add(b16);

				Order b17 = new Order()
				{
					OrderNumber = 222006,
					OrderDate = new DateTime(2022, 3, 21),
				};
				b17.Customer = db.Users.FirstOrDefault(g => g.UserName == "jorge@hootmail.com");
				b17.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "");
				Orders.Add(b17);

				Order b18 = new Order()
				{
					OrderNumber = 222006,
					OrderDate = new DateTime(2022, 3, 21),
				};
				b18.Customer = db.Users.FirstOrDefault(g => g.UserName == "jorge@hootmail.com");
				b18.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "");
				Orders.Add(b18);

				Order b19 = new Order()
				{
					OrderNumber = 222007,
					OrderDate = new DateTime(2022, 3, 25),
				};
				b19.Customer = db.Users.FirstOrDefault(g => g.UserName == "jorge@hootmail.com");
				b19.Promotion = db.Promotions.FirstOrDefault(g => g.PromoCode == "");
				Orders.Add(b19);

			try
			{
				foreach (Order OrderToAdd in Orders)
				{
					int OrderNumber = OrderToAdd.OrderNumber;
					Order dbOrder = db.Orders.FirstOrDefault(b => b.OrderID == OrderToAdd.OrderID);
					if (dbOrder == null)
					{
						db.Orders.Add(OrderToAdd);
						db.SaveChanges();
						intOrdersAdded += 1;
					}
					else
					{
						dbOrder.Customer = OrderToAdd.Customer;
						dbOrder.Promotion = OrderToAdd.Promotion;
						dbOrder.OrderNumber = OrderToAdd.OrderNumber;
						dbOrder.OrderDate = OrderToAdd.OrderDate;
						db.Update(dbOrder);
						db.SaveChanges();
						intOrdersAdded += 1;
					}
				}
			}
			catch (Exception ex)
			{
				String msg = "Repositories added:"+ intOrdersAdded +"; Error on "+ intOrderNumber;
				throw new InvalidOperationException(ex.Message + msg);
			}
		}
	}
}
