using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssignmentLibraryUML.Classes
{
    public class Departments // Class for different departments in the library
    {
        // Attributes
        public string departmentName;
        public string listaBookTitles;
        public string listMagazineTitles;
        public string listDVDTitles;
        public string categories;

        public void showDepartmentInfo() // How items are stored in the the department
        {
            Console.WriteLine($"This is the {departmentName}. The categories of items stored here are {categories}.");
        }
    }
}
