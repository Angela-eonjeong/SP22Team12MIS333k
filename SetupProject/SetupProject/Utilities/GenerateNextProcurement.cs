using SetupProject.DAL;
using System;
using System.Linq;


namespace SetupProject.Utilities
{
    public static class GenerateNextProcurementOrderNumber
    {
        public static Int32 GetNextProcurementOrderNumber(AppDbContext _context)
        {

            const Int32 START_NUMBER = 1;
            Int32 intMaxProcurementOrderNumber; //the current maximum order number
            Int32 intNextProcurementOrderNumber; //the order number for the next order

            if (_context.ProcurementOrders.Count() == 0) //there are no orders in the database yet
            {
                intMaxProcurementOrderNumber = START_NUMBER; //registration numbers start at 10001
            }
            else
            {
                intMaxProcurementOrderNumber = _context.ProcurementOrders.Max(c => c.ProcurementOrderNumber); //this is the highest number in the database right now
            }

            if (intMaxProcurementOrderNumber < START_NUMBER)
            {
                intMaxProcurementOrderNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextProcurementOrderNumber = intMaxProcurementOrderNumber + 1;

            //return the value
            return intNextProcurementOrderNumber;
        }

    }
}