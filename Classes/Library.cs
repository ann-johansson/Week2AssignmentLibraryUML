using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssignmentLibraryUML.Classes
{
    public class Library // The library itself
    {
        // Attributes
        string libraryDetails;

        public void OpenLibrary() // Method for opening the library
        {
            Console.WriteLine("The library is now open.");
        }
        public void CloseLibrary() // Method for closing the library
        {
            Console.WriteLine("The library is now closed.");
        }
    }
}
