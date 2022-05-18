using SetupProject.DAL;
using SetupProject.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SetupProject.Seeding
{
	public static class SeedProcurementDetails
	{
		public static void SeedAllProcurementDetails(AppDbContext db)
		{
			Int32 intProcurementDetailsAdded = 0;
			String strProcurementDetail = "Begin";
			//Add the list of ProcurementDetails
			List<ProcurementDetail> ProcurementDetails = new List<ProcurementDetail>();
				ProcurementDetail b1 = new ProcurementDetail()
				{
					Quantity = 8,
				};
				b1.Book = db.Books.FirstOrDefault(g => g.Title == "Quicksilver");
				b1.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222013);

				ProcurementDetail b2 = new ProcurementDetail()
				{
					Quantity = 5,
				};
				b2.Book = db.Books.FirstOrDefault(g => g.Title == "Full Black");
				b2.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222026);

				ProcurementDetail b3 = new ProcurementDetail()
				{
					Quantity = 4,
				};
				b3.Book = db.Books.FirstOrDefault(g => g.Title == "The Sixth Man");
				b3.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222056);

				ProcurementDetail b4 = new ProcurementDetail()
				{
					Quantity = 5,
				};
				b4.Book = db.Books.FirstOrDefault(g => g.Title == "Midst Toil And Tribulation");
				b4.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222062);

				ProcurementDetail b5 = new ProcurementDetail()
				{
					Quantity = 5,
				};
				b5.Book = db.Books.FirstOrDefault(g => g.Title == "77 Shadow Street");
				b5.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222064);

				ProcurementDetail b6 = new ProcurementDetail()
				{
					Quantity = 3,
				};
				b6.Book = db.Books.FirstOrDefault(g => g.Title == "Hunting Eve");
				b6.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222112);

				ProcurementDetail b7 = new ProcurementDetail()
				{
					Quantity = 8,
				};
				b7.Book = db.Books.FirstOrDefault(g => g.Title == "A Lesson In Secrets");
				b7.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222124);

				ProcurementDetail b8 = new ProcurementDetail()
				{
					Quantity = 6,
				};
				b8.Book = db.Books.FirstOrDefault(g => g.Title == "The Pursuit");
				b8.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222150);

				ProcurementDetail b9 = new ProcurementDetail()
				{
					Quantity = 5,
				};
				b9.Book = db.Books.FirstOrDefault(g => g.Title == "Shanghai Girls");
				b9.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222208);

				ProcurementDetail b10 = new ProcurementDetail()
				{
					Quantity = 3,
				};
				b10.Book = db.Books.FirstOrDefault(g => g.Title == "Twin Peaks: The Final Dossier");
				b10.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222209);

				ProcurementDetail b11 = new ProcurementDetail()
				{
					Quantity = 3,
				};
				b11.Book = db.Books.FirstOrDefault(g => g.Title == "Death On The D-List");
				b11.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222222);

				ProcurementDetail b12 = new ProcurementDetail()
				{
					Quantity = 4,
				};
				b12.Book = db.Books.FirstOrDefault(g => g.Title == "4 3 2 1");
				b12.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222232);

				ProcurementDetail b13 = new ProcurementDetail()
				{
					Quantity = 4,
				};
				b13.Book = db.Books.FirstOrDefault(g => g.Title == "Call Me Irresistible");
				b13.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222278);

				ProcurementDetail b14 = new ProcurementDetail()
				{
					Quantity = 6,
				};
				b14.Book = db.Books.FirstOrDefault(g => g.Title == "Dead Or Alive");
				b14.Book = db.Books.FirstOrDefault(g => g.UniqueNumber == 222292);

			try
			{
				foreach (ProcurementDetail ProcurementDetailToAdd in ProcurementDetails)
				{
					int ProcurementDetailID = ProcurementDetailToAdd.ProcurementDetailID;
					ProcurementDetail dbProcurementDetail = db.ProcurementDetails.FirstOrDefault(b => b.ProcurementDetailID == ProcurementDetailToAdd.ProcurementDetailID);
					if (dbProcurementDetail == null)
					{
						db.ProcurementDetails.Add(ProcurementDetailToAdd);
						db.SaveChanges();
						intProcurementDetailsAdded += 1;
					}
					else
					{
						dbProcurementDetail.Book = ProcurementDetailToAdd.Book;
						dbProcurementDetail.Quantity = ProcurementDetailToAdd.Quantity;
						db.Update(dbProcurementDetail);
						db.SaveChanges();
						intProcurementDetailsAdded += 1;
					}
				}
			}
			catch (Exception ex)
			{
				String msg = "Repositories added:"+ intProcurementDetailsAdded +"; Error on "+ strProcurementDetail;
				throw new InvalidOperationException(ex.Message + msg);
			}
		}
	}
}
