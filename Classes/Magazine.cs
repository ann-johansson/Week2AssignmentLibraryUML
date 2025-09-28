using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssignmentLibraryUML.Classes
{
    public class Magazine : LibraryItem // A type of inherited LibraryItem that represents magazines
    {
        // Attributes
        public string publisher;

        public override void UseItem() // Using the item, this is an abstract method from LibraryItem
        {
             Console.WriteLine($"Reading the magazine: {title}, published by {publisher}.");
        }
    }
}
