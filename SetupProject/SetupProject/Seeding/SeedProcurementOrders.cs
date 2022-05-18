using SetupProject.DAL;
using SetupProject.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SetupProject.Seeding
{
	public static class SeedProcurementOrders
	{
		public static void SeedAllProcurementOrders(AppDbContext db)
		{
			Int32 intProcurementOrdersAdded = 0;
			String strProcurementOrder = "Begin";
			//Add the list of ProcurementOrders
			List<ProcurementOrder> ProcurementOrders = new List<ProcurementOrder>();
				ProcurementOrder b1 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222013,
					Status = false,
				};

				ProcurementOrder b2 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222026,
					Status = false,
				};

				ProcurementOrder b3 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222056,
					Status = false,
				};

				ProcurementOrder b4 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222062,
					Status = false,
				};

				ProcurementOrder b5 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222064,
					Status = false,
				};

				ProcurementOrder b6 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222112,
					Status = false,
				};

				ProcurementOrder b7 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222124,
					Status = false,
				};

				ProcurementOrder b8 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222150,
					Status = false,
				};

				ProcurementOrder b9 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222208,
					Status = false,
				};

				ProcurementOrder b10 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222209,
					Status = false,
				};

				ProcurementOrder b11 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222222,
					Status = false,
				};

				ProcurementOrder b12 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222232,
					Status = false,
				};

				ProcurementOrder b13 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222278,
					Status = false,
				};

				ProcurementOrder b14 = new ProcurementOrder()
				{
					ProcurementOrderNumber = 222292,
					Status = false,
				};

			try
			{
				foreach (ProcurementOrder ProcurementOrderToAdd in ProcurementOrders)
				{
					int ProcurementOrderID = ProcurementOrderToAdd.ProcurementOrderID;
					ProcurementOrder dbProcurementOrder = db.ProcurementOrders.FirstOrDefault(b => b.ProcurementOrderID == ProcurementOrderToAdd.ProcurementOrderID);
					if (dbProcurementOrder == null)
					{
						db.ProcurementOrders.Add(ProcurementOrderToAdd);
						db.SaveChanges();
						intProcurementOrdersAdded += 1;
					}
					else
					{
						dbProcurementOrder.Status = ProcurementOrderToAdd.Status;
						dbProcurementOrder.ProcurementOrderNumber = ProcurementOrderToAdd.ProcurementOrderNumber;
						db.Update(dbProcurementOrder);
						db.SaveChanges();
						intProcurementOrdersAdded += 1;
					}
				}
			}
			catch (Exception ex)
			{
				String msg = "Repositories added:"+ intProcurementOrdersAdded +"; Error on "+ strProcurementOrder;
				throw new InvalidOperationException(ex.Message + msg);
			}
		}
	}
}
