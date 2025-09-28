 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssignmentLibraryUML.Classes
{
    public class Book : LibraryItem // An inherited type of LibraryItem that represents books
    {
        // Attributes
        public string author;
        public int pages;

        public override void UseItem() // Using the item, this is an abstract method from LibraryItem
        {
            Console.WriteLine($"Reading the book: {title} by {author}, which has {pages} pages.");
        }
    }
}
