using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssignmentLibraryUML.Classes
{
    public class Librarian // The Librarians in the library
    {
        // Attributes
        private string contactDetailsLibrarian;
        public string tasks;

        public void ManageItems() // How the librarian manages the items in the library
        {
            Console.WriteLine($"The librarian is managing library items and doing {tasks}.");
        }
        public void HelpPatrons() // How the librarian helps the patrons in the library
        {
            Console.WriteLine("Helping library patrons.");
        }
        public void LendingItems() // When the librarian lends items to patrons
        {
            Console.WriteLine("Lending items to patrons.");
        }
        public void ReturningItems() // When the librarian processes returned items
        {
            Console.WriteLine("Processing returned items.");
        }
    }
}
