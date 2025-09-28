using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssignmentLibraryUML.Classes
{
    public abstract class LibraryItem // The items in the library
    {
        // Attributes
        public string title;
        public string published;
        public string ID;
        public string placementShelf;

        public abstract void UseItem(); // Method for using the item, abstract as it depends on the item type

    }
}
