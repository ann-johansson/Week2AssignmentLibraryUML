using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssignmentLibraryUML.Classes
{
    public class DVD : LibraryItem // A type of inherited LibraryItem that represents DVDs
    {
        // Attributes
        public string director;
        public int duration;

        public override void UseItem() // Using the item, this is an abstract method from LibraryItem
        {
            Console.WriteLine($"Watching the DVD: {title} by {director}, which lasts {duration} minuts.");
        }
    }
}
