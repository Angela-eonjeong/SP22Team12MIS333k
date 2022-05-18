using SetupProject.DAL;
using System;
using System.Linq;

namespace SetupProject.Utilities
{
    public static class GenerateBookUniqueNumber
    {
        public static Int32 GetNextBookUniqueNumber (AppDbContext _context)
        {
            //Set a number where the Product numbers should start
            const Int32 START_NUMBER = 222001;

            Int32 intMaxBookUniqueNumber; //the current maximum Product number
            Int32 intNextBookUniqueNumber; //the Product number for the next class

            if (_context.Books.Count() == 0) //there are no Products in the database yet
            {
                intMaxBookUniqueNumber = START_NUMBER; //Product numbers start at 3001
            }
            else
            {
                intMaxBookUniqueNumber = _context.Books.Max(c => c.UniqueNumber); //this is the highest number in the database right now
            }

            //You added Products before you realized that you needed this code
            //and now you have some Product numbers less than 3000
            if (intMaxBookUniqueNumber < START_NUMBER)
            {
                intMaxBookUniqueNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextBookUniqueNumber = intMaxBookUniqueNumber + 1;

            //return the value
            return intNextBookUniqueNumber;
        }

    }
}