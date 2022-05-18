using SetupProject.DAL;
using SetupProject.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SetupProject.Seeding
{
	public static class SeedPaymentMethods
	{
		public static void SeedAllPaymentMethods(AppDbContext db)
		{
			Int32 intPaymentMethodsAdded = 0;
			String strCardNumber = "Begin";
			//Add the list of PaymentMethods
			List<PaymentMethod> PaymentMethods = new List<PaymentMethod>();
				PaymentMethod b1 = new PaymentMethod()
				{
					CardNumber = "4675645728421114",
					CardType = "Visa",
				};
				b1.Customer = db.Users.FirstOrDefault(g => g.UserName == "wendy@puppy.com");
				PaymentMethods.Add(b1);

				PaymentMethod b2 = new PaymentMethod()
				{
					CardNumber = "5503127677370884",
					CardType = "MasterCard",
				};
				b2.Customer = db.Users.FirstOrDefault(g => g.UserName == "wendy@puppy.com");
				PaymentMethods.Add(b2);

				PaymentMethod b3 = new PaymentMethod()
				{
					CardNumber = "6256807128623222",
					CardType = "Discover",
				};
				b3.Customer = db.Users.FirstOrDefault(g => g.UserName == "wendy@puppy.com");
				PaymentMethods.Add(b3);

				PaymentMethod b4 = new PaymentMethod()
				{
					CardNumber = "4950958175592751",
					CardType = "Visa",
				};
				b4.Customer = db.Users.FirstOrDefault(g => g.UserName == "jorge@hootmail.com");
				PaymentMethods.Add(b4);

				PaymentMethod b5 = new PaymentMethod()
				{
					CardNumber = "3699615701590378",
					CardType = "American Express",
				};
				b5.Customer = db.Users.FirstOrDefault(g => g.UserName == "tuck33@puppy.com");
				PaymentMethods.Add(b5);

				PaymentMethod b6 = new PaymentMethod()
				{
					CardNumber = "6211198035367129",
					CardType = "Discover",
				};
				b6.Customer = db.Users.FirstOrDefault(g => g.UserName == "tuck33@puppy.com");
				PaymentMethods.Add(b6);

				PaymentMethod b7 = new PaymentMethod()
				{
					CardNumber = "3471771011863082",
					CardType = "American Express",
				};
				b7.Customer = db.Users.FirstOrDefault(g => g.UserName == "luce_chuck@puppy.com");
				PaymentMethods.Add(b7);

				PaymentMethod b8 = new PaymentMethod()
				{
					CardNumber = "5213380951061278",
					CardType = "MasterCard",
				};
				b8.Customer = db.Users.FirstOrDefault(g => g.UserName == "luce_chuck@puppy.com");
				PaymentMethods.Add(b8);

				PaymentMethod b9 = new PaymentMethod()
				{
					CardNumber = "4456007408951970",
					CardType = "Visa",
				};
				b9.Customer = db.Users.FirstOrDefault(g => g.UserName == "westj@pioneer.net");
				PaymentMethods.Add(b9);

				PaymentMethod b10 = new PaymentMethod()
				{
					CardNumber = "6722087214695361",
					CardType = "Discover",
				};
				b10.Customer = db.Users.FirstOrDefault(g => g.UserName == "taylordjay@puppy.com");
				PaymentMethods.Add(b10);

				PaymentMethod b11 = new PaymentMethod()
				{
					CardNumber = "5393288375971482",
					CardType = "MasterCard",
				};
				b11.Customer = db.Users.FirstOrDefault(g => g.UserName == "taylordjay@puppy.com");
				PaymentMethods.Add(b11);

				PaymentMethod b12 = new PaymentMethod()
				{
					CardNumber = "3205012010695848",
					CardType = "American Express",
				};
				b12.Customer = db.Users.FirstOrDefault(g => g.UserName == "ss34@puppy.com");
				PaymentMethods.Add(b12);

				PaymentMethod b13 = new PaymentMethod()
				{
					CardNumber = "5852275483583440",
					CardType = "MasterCard",
				};
				b13.Customer = db.Users.FirstOrDefault(g => g.UserName == "ss34@puppy.com");
				PaymentMethods.Add(b13);

				PaymentMethod b14 = new PaymentMethod()
				{
					CardNumber = "3655719856572829",
					CardType = "American Express",
				};
				b14.Customer = db.Users.FirstOrDefault(g => g.UserName == "hicks43@puppy.com");
				PaymentMethods.Add(b14);

				PaymentMethod b15 = new PaymentMethod()
				{
					CardNumber = "4922220996800874",
					CardType = "Visa",
				};
				b15.Customer = db.Users.FirstOrDefault(g => g.UserName == "hicks43@puppy.com");
				PaymentMethods.Add(b15);

				PaymentMethod b16 = new PaymentMethod()
				{
					CardNumber = "4315122297470156",
					CardType = "Visa",
				};
				b16.Customer = db.Users.FirstOrDefault(g => g.UserName == "hicks43@puppy.com");
				PaymentMethods.Add(b16);

				PaymentMethod b17 = new PaymentMethod()
				{
					CardNumber = "5771359616496493",
					CardType = "MasterCard",
				};
				b17.Customer = db.Users.FirstOrDefault(g => g.UserName == "limchou@puppy.com");
				PaymentMethods.Add(b17);

				PaymentMethod b18 = new PaymentMethod()
				{
					CardNumber = "5748124811574140",
					CardType = "MasterCard",
				};
				b18.Customer = db.Users.FirstOrDefault(g => g.UserName == "erynrice@puppy.com");
				PaymentMethods.Add(b18);

				PaymentMethod b19 = new PaymentMethod()
				{
					CardNumber = "6307018670622924",
					CardType = "Discover",
				};
				b19.Customer = db.Users.FirstOrDefault(g => g.UserName == "orielly@foxnets.com");
				PaymentMethods.Add(b19);

			try
			{
				foreach (PaymentMethod PaymentMethodToAdd in PaymentMethods)
				{
					strCardNumber = PaymentMethodToAdd.CardNumber;
					PaymentMethod dbPaymentMethod = db.PaymentMethods.FirstOrDefault(b => b.CardNumber == PaymentMethodToAdd.CardNumber);
					if (dbPaymentMethod == null)
					{
						db.PaymentMethods.Add(PaymentMethodToAdd);
						db.SaveChanges();
						intPaymentMethodsAdded += 1;
					}
					else
					{
						dbPaymentMethod.CardNumber = PaymentMethodToAdd.CardNumber;
						dbPaymentMethod.CardType = PaymentMethodToAdd.CardType;
						dbPaymentMethod.Customer = PaymentMethodToAdd.Customer;
						db.Update(dbPaymentMethod);
						db.SaveChanges();
						intPaymentMethodsAdded += 1;
					}
				}
			}
			catch (Exception ex)
			{
				String msg = "Repositories added:"+ intPaymentMethodsAdded +"; Error on "+ strCardNumber;
				throw new InvalidOperationException(ex.Message + msg);
			}
		}
	}
}
