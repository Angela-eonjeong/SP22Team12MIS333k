using SetupProject.DAL;
using SetupProject.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SetupProject.Seeding
{
	public static class SeedPromotions
	{
		public static void SeedAllPromotions(AppDbContext db)
		{
			Int32 intPromotionsAdded = 0;
			String strPromoDescription = "Begin";
			List<Promotion> Promotions = new List<Promotion>();
				Promotion b1 = new Promotion()
				{
					PromoCode = "HOOKEM50",
					PromoDescription = "50% Discount",
					Status = true,
				};
				Promotions.Add(b1);

				Promotion b2 = new Promotion()
				{
					PromoCode = "SHIP50",
					PromoDescription = "Free shipping over $30",
					Status = false,
				};
				Promotions.Add(b2);

				Promotion b3 = new Promotion()
				{
					PromoCode = "FREESHIPPING512",
					PromoDescription = "Free shipping on any order",
					Status = true,
				};
				Promotions.Add(b3);

				Promotion b4 = new Promotion()
				{
					PromoCode = "FriendsWithDerek",
					PromoDescription = "90% discount",
					Status = true,
				};
				Promotions.Add(b4);

				Promotion b5 = new Promotion()
				{
					PromoCode = "IfIFitsIShips",
					PromoDescription = "Free shipping on any order",
					Status = true,
				};
				Promotions.Add(b5);

			try
			{
				foreach (Promotion promotionToAdd in Promotions)
				{
					strPromoDescription = promotionToAdd.PromoDescription;
					Promotion dbPromotion = db.Promotions.FirstOrDefault(b => b.PromoDescription == promotionToAdd.PromoDescription);
					if (dbPromotion == null)
					{
						db.Promotions.Add(promotionToAdd);
						db.SaveChanges();
						intPromotionsAdded += 1;
					}
					else
					{
						dbPromotion.PromoCode = promotionToAdd.PromoCode;
						dbPromotion.PromoDescription = promotionToAdd.PromoDescription;
						dbPromotion.Status = promotionToAdd.Status;
						db.Update(dbPromotion);
						db.SaveChanges();
						intPromotionsAdded += 1;
					}
				}
			}
			catch (Exception ex)
			{
				String msg = "Repositories added:"+ intPromotionsAdded +"; Error on "+ strPromoDescription;
				throw new InvalidOperationException(ex.Message + msg);
			}
		}
	}
}
