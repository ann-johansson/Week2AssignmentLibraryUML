namespace Week2AssignmentLibraryUML.Classes
{
    namespace Week2AssignmentLibraryUML
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Book book = new Book();
                Departments FictionDepartment = new Departments();
                DVD dvd = new DVD();
                Librarian librarian = new Librarian();
                Library library = new Library();
                LibraryPatron libraryPatron = new LibraryPatron();
                Loans loans = new Loans();
                Magazine magazine = new Magazine();

                // opening the library
                library.OpenLibrary();

                // The librarians tasks
                Console.WriteLine("\nSo, what does the librarian do?");
                librarian.tasks = "cataloging, shelving, and assisting patrons";
                librarian.ManageItems();
                librarian.HelpPatrons();
                librarian.LendingItems();
                librarian.ReturningItems();

                // What the library patron does
                Console.WriteLine("\nNow, what about the library patron?");
                libraryPatron.Borrow(); // Borrowing an item
                libraryPatron.Return(); // Returning an item

                // The loans information
                Console.WriteLine("\nSo, what about the patrons loans?");
                loans.reminders = "14 days";
                loans.LoanTime(); // Showing the loan time
                loans.borrowAgain(); // Borrowing an item again
                loans.borrowedItems = "The Great Gatsby, Inception DVD, National Geographic Magazine";
                loans.showLoans(); // Showing the borrowed items

                Console.WriteLine("\nOh! Some of our patrons looks at our most popular items:");
                // The Book item
                book.title = "My very long Biography 2.0 - And Love Letter";
                book.author = "Secret Admirer";
                book.pages = 28015;
                book.UseItem(); // Using the book item

                // The DVD item
                dvd.title = "Jurassic Cookies";
                dvd.director = "Nonchalant Baker";
                dvd.duration = 347;
                dvd.UseItem(); // Using the DVD item

                // The Magazine item
                magazine.title = "Quantum Physics on a Mind Numbing Level";
                magazine.publisher = "New Meee";
                magazine.UseItem(); // Using the magazine item

                // The Fiction Department
                Console.WriteLine("\nHere is one of our departments:");
                FictionDepartment.departmentName = "Fiction Department";
                FictionDepartment.categories = "Novels, Short Stories, Poetry, DVDs";
                FictionDepartment.showDepartmentInfo();

                // closing the library
                Console.WriteLine("\nAnd now it is time to close the library for today!");
                library.CloseLibrary();
            }
        }
    }
}
