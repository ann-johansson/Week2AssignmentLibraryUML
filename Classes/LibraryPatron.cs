using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssignmentLibraryUML.Classes
{
    public class LibraryPatron // The patrons (customers) of the library
    {
        // Attributes
        private string contactDetailsPatron;

        public void Borrow() // Method for borrowing an item from the library
        {
            Console.WriteLine("The patron is borrowing an item from the library.");
        }
        public void Return() // Method for returning an item to the library
        {
            Console.WriteLine("The patron is returning an item to the library.");
        }
    }
}
