using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssignmentLibraryUML.Classes
{
    public class Loans // The patron's loans in the library
    {
        // Attributes
        public string borrowedItems;
        public string returnedItems;
        public string reminders;

        public void LoanTime() // Method for showing the loan time
        {             
            Console.WriteLine($"You have {reminders} left on you loan.");
        }
        public void borrowAgain() // Method for borrowing an item again
        {
            Console.WriteLine("You have borrowed the item again.");
        }
        public void showLoans() // Method for showing the borrowed items
        {
            Console.WriteLine($"You have borrowed the following items: {borrowedItems}");
        }
    }
}
