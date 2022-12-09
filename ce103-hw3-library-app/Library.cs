using System;
using ce103_hw3_library_lib;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Net.WebRequestMethods;
using System.Runtime.InteropServices.ComTypes;
using System.Net.NetworkInformation;

namespace ce103_hw3_library_app
{
    class Library
    {
        public void Password()
        {
            byte[] passhash = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes("admin"));
            WriteLine(@"




                                                      Welcome, Sure.
 
                                          Enter your password to enter the system.");
            Console.SetCursorPosition(22, 9);
            Console.WriteLine("Enter a password:");
            Console.SetCursorPosition(39, 9);
            StringBuilder enteredpassbuilder = new StringBuilder();
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (enteredpassbuilder.Length < 0)
                    {
                        enteredpassbuilder.Remove(enteredpassbuilder.Length - 1, 1);
                    }
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);

                }
                else
                {
                    enteredpassbuilder.Append(key.KeyChar);
                    Console.Write("*");
                }
            }

            string enteredpass = enteredpassbuilder.ToString();
            byte[] enteredpasshash = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(enteredpass));
            if (passhash.SequenceEqual(enteredpasshash))
            {
                Start();
            }
            else
            {
                WriteLine("The password you entered is incorrect. Exiting...");
            }
        }
        public void Start()

        {
            Title = "ce103-hm3- The Library Management";
            RunMainMenu();
        }
        private void RunMainMenu()
        {
            string prompt = @"

 _     _ _                                                                                        _    
| |   (_) |                                                                                      | |   
| |    _| |__  _ __ __ _ _ __ _   _   _ __ ___   __ _ _ __   __ _  __ _  ___ _ __ ___   ___ _ __ | |_  
| |   | | '_ \| '__/ _` | '__| | | | | '_ ` _ \ / _` | '_ \ / _` |/ _` |/ _ \ '_ ` _ \ / _ \ '_ \| __| 
| |___| | |_) | | | (_| | |  | |_| | | | | | | | (_| | | | | (_| | (_| |  __/ | | | | |  __/ | | | |_  
\_____/_|_.__/|_|  \__,_|_|   \__, | |_| |_| |_|\__,_|_| |_|\__,_|\__, |\___|_| |_| |_|\___|_| |_|\__| 
                               __/ |                               __/ |                               
                              |___/                               |___/                                


WELCOME ";
            string[] options = { "Add Book", "Edit Book", "Borrow/Return Book", "Book List", "Search Book", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    AddBook();
                    break;
                case 1:
                    EditBook();
                    break;
                case 3:
                    BorrowReturnBook();
                    break;
                case 4:
                    BookList();
                    break;
                case 5:
                    SearchBook();
                    break;
                case 6:
                    Exit();
                    RunMainMenu();
                    break;
            }

        }
        private void AddBook()
        {
            string prompt = "Choose a category";
            string[] options = { "Action and Adventure", "Classics", "Comic Book or Graphic Novel", "Detective and Mystery", "Fantasy", "Historical Fiction", "Horror", "Literary Fiction", "Back to MENU"};
            Menu colorMenu = new Menu(prompt, options);
            int selectedIndex = colorMenu.Run();

            BackgroundColor = ConsoleColor.Black;
            switch (selectedIndex)
            {
                case 0:
                    ActionAndAdventure();
                    RunMainMenu();
                    break;
                case 1:
                    Classics();
                    RunMainMenu();
                    break;
                case 2:
                    ComicBook();
                    RunMainMenu();
                    break;
                case 3:
                    Detective();
                    RunMainMenu();
                    break;
                case 4:
                    Fantasy();
                    RunMainMenu();
                    break;
                case 5:
                    Historical();
                    RunMainMenu();
                    break;
                case 6:
                    Horror();
                    RunMainMenu();
                    break;
                case 7:
                    LiteraryFiction();
                    RunMainMenu();
                    break;
                case 8:
                    Exit();
                    RunMainMenu();
                    break;

            }
        }
        private void GetBookInfo(string catalogType)
        {
            if (!System.IO.File.Exists("C:\\Users\\Ali\\Desktop\\ce103-hw3-ali-emre\\Library.dat"))
            {
                System.IO.File.Create("C:\\Users\\Ali\\Desktop\\ce103-hw3-ali-emre\\Library.dat");
            }

            Clear();

            string a;

            Console.WriteLine("Enter ID: ");
            a = Console.ReadLine();

            string b = string.Empty;

            Console.WriteLine("Enter book name: ");
            b = Console.ReadLine();

            string type2 = string.Empty;

            Console.WriteLine("Enter author name: ");
            type2 = Console.ReadLine();

            string c = string.Empty;

            Console.WriteLine("Enter pubication year of the book: ");
            c = Console.ReadLine();

            string d = string.Empty;

            Console.WriteLine("Enter pubication city of the book: ");
            d = Console.ReadLine();

            string e = string.Empty;

            Console.WriteLine("Enter number of pages of the book: ");
            e = Console.ReadLine();

            string f = string.Empty;

            Console.WriteLine("Enter the book abstract: ");
            f = Console.ReadLine();

            string g = string.Empty;

            Console.WriteLine("Enter the book author keywors: ");
            g = Console.ReadLine();

            string h = string.Empty;

            Console.WriteLine("Enter the editors: ");
            h = Console.ReadLine();

            string i = string.Empty;

            Console.WriteLine("Enter publisher of the book: ");
            i = Console.ReadLine();

            string j = string.Empty;

            Console.WriteLine("Enter Book URL: ");
            j = Console.ReadLine();

            string k = string.Empty;

            Console.WriteLine("Enter catalog IDS: ");
            k = Console.ReadLine();

            string y = string.Empty;

            Console.WriteLine("Enter book price: ");
            y = Console.ReadLine();

            string l = string.Empty;

            Console.WriteLine("Enter book location: ");
            l = Console.ReadLine();

            string m = string.Empty;

            Console.WriteLine("Enter book status: ");
            m = Console.ReadLine();

            string n = string.Empty;

            Console.WriteLine("Enter given datetime: ");
            n = Console.ReadLine();

            string o = string.Empty;

            Console.WriteLine("Enter return datetime: ");
            o = Console.ReadLine();

            ce103_hw3_library_lib.Book book = new ce103_hw3_library_lib.Book();
            book.Id = a;
            book.Title = b;
            book.Description = f;
            book.Authors.Add(b);
            book.Categories.Add(catalogType);
            book.Year = c;
            book.City = d;
            book.Pages = e;
            book.Keywords = g;
            book.Editors.Add(h);
            book.Publisher = i;
            book.URL = j;
            book.CatalogIDS = k;
            book.Price = y;
            book.Location = l;
            book.Status = m;
            book.GivenDatetime = n;
            book.ReturnDatetime = o;
            byte[] bookBytes = ce103_hw3_library_lib.Book.BookToByteArrayBlock(book);
            ce103_hw3_library_lib.FileUtility.AppendBlock(bookBytes, "C:\\Users\\Ali\\Desktop\\ce103-hw3-ali-emre\\Library.dat");

            WriteLine("\nBook successfully added...");
            ReadKey(true);
            RunMainMenu();
        }

        private void LiteraryFiction()
        {
            string catalogType = "Literary Fiction";
            GetBookInfo(catalogType);
            RunMainMenu();
        }

        private void Horror()
        {
            string catalogType = "Horror";
            GetBookInfo(catalogType);
            RunMainMenu();
        }

        private void Historical()
        {
            string catalogType = "Historical";
            GetBookInfo(catalogType);
            RunMainMenu();
        }

        private void Fantasy()
        {
            string catalogType = "Fantasy";
            GetBookInfo(catalogType);
            RunMainMenu();
        }

        private void Detective()
        {
            string catalogType = "Literary Fiction";
            GetBookInfo(catalogType);
            RunMainMenu();
        }

        private void ComicBook()
        {
            string catalogType = "Comic Book";
            GetBookInfo(catalogType);
            RunMainMenu();
        }

        private void Classics()
        {
            string catalogType = "Classics";
            GetBookInfo(catalogType);
            RunMainMenu();
        }

        private void ActionAndAdventure()
        {
            string catalogType = "Action and Adventure";
            
            GetBookInfo(catalogType);
            RunMainMenu();
        }

        private void EditBook()
        {
            string prompt = " ";
            string[] options = { "Delete Book", "Update Book","Back to MENU" };
            Menu colorMenu = new Menu(prompt, options);
            int selectedIndex = colorMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    DeleteBook();
                    break;
                case 1:
                    UpdateBook();
                    break;
                case 2:
                    Exit();
                    RunMainMenu();
                    break;
            }

            void DeleteBook()
            {
                int del;
                Clear();
                Console.WriteLine("Enter the ID of the book you want to delete: ");
                del = Convert.ToInt32(Console.ReadLine());

                string prompt1 = "Are you sure you want to delete?";
                string[] options1 = { "YES", "NO" };
                Menu Menu1 = new Menu(prompt1, options1);
                int selectedIndex2 = Menu1.Run();

                switch (selectedIndex2)
                {
                    case 0:
                        YES();
                        break;
                    case 1:
                        NO();
                        break;
                }

                void NO()
                {
                    WriteLine("\nBook couldn't delete...");
                    ReadKey(true);
                    RunMainMenu();
                }

                void YES()
                {
                    byte[] bookWrittenBytes = FileUtility.ReadBlock(1, Book.BOOK_DATA_BLOCK_SIZE, "C:\\Users\\Ali\\Desktop\\ce103-hw3-ali-emre\\Library.dat");
                    Book bookWrittenObject = Book.ByteArrayBlockToBook(bookWrittenBytes);

                    FileUtility.DeleteBlock(2, Book.ID_MAX_LENGTH, "C:\\Users\\Ali\\Desktop\\ce103-hw3-ali-emre\\Library.dat");
                    bookWrittenBytes = FileUtility.ReadBlock(2, Book.ID_MAX_LENGTH, "C:\\Users\\Ali\\Desktop\\ce103-hw3-ali-emre\\Library.dat");
                    bookWrittenObject = Book.ByteArrayBlockToBook(bookWrittenBytes);

                    WriteLine("\nBook deleted successfully...");
                    ReadKey(true);
                    RunMainMenu();
                }
            }

            void UpdateBook()
            {
                string update = string.Empty;
                Clear();
                Console.WriteLine("Enter the ID of the book you want to update: ");
                update = Console.ReadLine();

                string prompt1 = "Select the information of the book you want to change: ";
                string[] options1 = { "ID", "NAME", "AUTHOR", "YEAR", "CITY", "PAGES", "ABSTRACT", "KEYWORDS", "EDITORS", "PUBLISHER", "URL", "CATATLOG IDS", "PRICE", "LOCATION", "STATUS", "GIVEN DATETIME", "RETURN DATETIME" };
                Menu Menu1 = new Menu(prompt1, options1);
                int selectedIndex2 = Menu1.Run();

                switch (selectedIndex2)
                {
                    case 0:
                        ID();
                        break;
                    case 1:
                        NAME();
                        break;
                    case 2:
                        AUTHOR();
                        break;
                    case 3:
                        YEAR();
                        break;
                    case 4:
                        CITY();
                        break;
                    case 5:
                        PAGES();
                        break;
                    case 6:
                        ABSTRACT();
                        break;
                    case 7:
                        KEYWORDS();
                        break;
                    case 8:
                        EDITORS();
                        break;
                    case 9:
                        PUBLISHER();
                        break;
                    case 10:
                        URL();
                        break;
                    case 11:
                        CATATLOGIDS();
                        break;
                    case 12:
                        PRICE();
                        break;
                    case 13:
                        LOCATION();
                        break;
                    case 14:
                        STATUS();
                        break;
                    case 15:
                        GIVENDATETIME();
                        break;
                    case 16:
                        RETURNDATETIME();
                        break;


                }
                RunMainMenu();

                bool UpdateBookID(string oldID, string newID, string path)
                {
                    // Read the block of data containing the book with the old ID
                    byte[] bookWrittenBytes = FileUtility.ReadBlock(Convert.ToInt32(oldID), Book.BOOK_DATA_BLOCK_SIZE, path);

                    // Make sure the book data was found
                    if (bookWrittenBytes == null)
                    {
                        // Return false to indicate that the book ID could not be updated
                        return false;
                    }

                    // Convert the byte array to a Book object
                    Book bookWrittenObject = Book.ByteArrayBlockToBook(bookWrittenBytes);

                    // Make sure the Book object was created successfully
                    if (bookWrittenObject == null)
                    {
                        // Return false to indicate that the book ID could not be updated
                        return false;
                    }

                    // Update the book ID
                    bookWrittenObject.Id = newID;

                    // Convert the updated book object to a byte array
                    byte[] updatedBookBytes = Book.BookToByteArrayBlock(bookWrittenObject);

                    // Use FileUtility.UpdateBlock to update the book data in the file
                    return FileUtility.UpdateBlock(updatedBookBytes, 1, Book.BOOK_DATA_BLOCK_SIZE, path);
                }

                void ID()
                {
                    string up0;
                    Clear();
                    Console.WriteLine("Enter the registered ID of the book: ");
                    up0 = Console.ReadLine();

                    string up1;
                    Clear();
                    Console.WriteLine("Enter the new ID of the book: ");
                    up1 = Console.ReadLine();

                    bool _ = UpdateBookID(up0, up1, "C:\\Users\\Ali\\Desktop\\ce103-hw3-ali-emre\\Library.dat");
                }

                void NAME()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered name of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new name of the book: ");
                    up1 = Console.ReadLine();
                }

                void AUTHOR()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered author of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new author of the book: ");
                    up1 = Console.ReadLine();
                }

                void YEAR()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered year of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new year of the book: ");
                    up1 = Console.ReadLine();
                }

                void CITY()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered city of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new ctiy of the book: ");
                    up1 = Console.ReadLine();
                }

                void PAGES()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered pages of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new pages of the book: ");
                    up1 = Console.ReadLine();
                }

                void ABSTRACT()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered abstract of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new abstract of the book: ");
                    up1 = Console.ReadLine();
                }

                void KEYWORDS()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered keywords of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new keywords of the book: ");
                    up1 = Console.ReadLine();
                }

                void EDITORS()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered editors of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new editors of the book: ");
                    up1 = Console.ReadLine();
                }

                void PUBLISHER()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered publisher of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new publisher of the book: ");
                    up1 = Console.ReadLine();
                }

                void URL()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered URL of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new URL of the book: ");
                    up1 = Console.ReadLine();
                }

                void CATATLOGIDS()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered catalog IDS of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new catalog IDS of the book: ");
                    up1 = Console.ReadLine();
                }

                void PRICE()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered price of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new price of the book: ");
                    up1 = Console.ReadLine();
                }

                void LOCATION()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered location of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new location of the book: ");
                    up1 = Console.ReadLine();
                }

                void STATUS()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered status of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new status of the book: ");
                    up1 = Console.ReadLine();
                }

                void GIVENDATETIME()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered given datetime of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new given datetime of the book: ");
                    up1 = Console.ReadLine();
                }

                void RETURNDATETIME()
                {
                    string up0 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the registered return datetime of the book: ");
                    up0 = Console.ReadLine();

                    string up1 = string.Empty;
                    Clear();
                    Console.WriteLine("Enter the new return datetime of the book: ");
                    up1 = Console.ReadLine();
                }

                WriteLine("\nBook updated successfully...");
                ReadKey(true);
                RunMainMenu();
            }
        }

        private void BorrowReturnBook()
        {
            string prompt = " ";
            string[] options = { "Borrow Book", "Return Book", "Lost Operations" , "Back to MENU" };
            Menu colorMenu = new Menu(prompt, options);
            int selectedIndex = colorMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    BorrowBook();
                    break;
                case 1:
                    ReturnBook();
                    break;
                case 2:
                    LostOperations();
                    break;
                case 3:
                    Exit();
                    RunMainMenu();
                    break;
            }

            void BorrowBook()
            {
                string borrow = string.Empty;
                Clear();
                Console.WriteLine("Enter the ID of the book you want to borrow: ");
                borrow = Console.ReadLine();

                string borrow1 = string.Empty;
                Clear();
                Console.WriteLine("Enter the borrower's Name-Surname : ");
                borrow1 = Console.ReadLine();

                string borrow2 = string.Empty;
                Clear();
                Console.WriteLine("Enter given datetime: ");
                borrow2 = Console.ReadLine();

                string borrow3 = string.Empty;
                Clear();
                Console.WriteLine("Enter returning datetime: ");
                borrow3 = Console.ReadLine();

                WriteLine("\nBook borrowed successfully...");
                ReadKey(true);
                RunMainMenu();
            }
            void ReturnBook()
            {
                string return0 = string.Empty;
                Clear();
                Console.WriteLine("Enter the ID of the book you want to return: ");
                return0 = Console.ReadLine();

                string return1 = string.Empty;
                Clear();
                Console.WriteLine("Enter the returner's Name-Surname : ");
                return1 = Console.ReadLine();

                string return2 = string.Empty;
                Clear();
                Console.WriteLine("Enter given datetime: ");
                return2 = Console.ReadLine();

                string return3 = string.Empty;
                Clear();
                Console.WriteLine("Enter returned datetime: ");
                return3 = Console.ReadLine();

                WriteLine("\nBook returned successfully...");
                ReadKey(true);
                RunMainMenu();

            }

            void LostOperations()
            {
                RunMainMenu();
            }
        }

        private void BookList()
        {
            RunMainMenu();
        }
        private void SearchBook()
        {

            Clear();
            Console.WriteLine("Are you sure you want to exit the application? (Y/N)");
            ConsoleKey key = Console.ReadKey().Key;

            if (key == ConsoleKey.Y)
            {
                Environment.Exit(0);
            }
            else
            {
                RunMainMenu();

            }
        }
        private void Exit()
        {
            RunMainMenu();
        }
    



        public void BookTest()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string filename = Path.Combine(path, "C:\\Users\\Ali\\Desktop\\ce103-hw3-ali-emre\\Library.dat");

            Book book1 = new Book();
            book1.Id = "5";
            book1.Title = "Demo Title 1";
            book1.Description = "Demo Description 1";
            book1.Authors.Add("Demo Author 1");
            book1.Categories.Add("ScienceFiction");
            book1.Categories.Add("Drama");
            book1.Year = "Demo Year";
            book1.City = "Demo City";
            book1.Pages = "Demo Pages";
            book1.Keywords = "Demo Keywords";
            book1.Editors.Add("Demo Editors");
            book1.Publisher = "Demo Publisher";
            book1.URL = "Demo URL";
            book1.CatalogIDS = "Demo Catalog IDS";
            book1.Price = "Demo Price";
            book1.Location = "Demo Location";
            book1.Status = "Demo Status";
            book1.GivenDatetime = "Demo Given Datetime";
            book1.ReturnDatetime = "Demo Return Datetime";

            Book book2 = new Book();
            book2.Id = "6";
            book2.Title = "Demo Title 2";
            book2.Description = "Demo Description 2";
            book2.Authors.Add("Demo Author 3");
            book2.Authors.Add("Demo Author 4");
            book2.Categories.Add("ScienceFiction");
            book2.Categories.Add("Drama");
            book2.Year = "Demo Year 2";
            book2.City = "Demo City 2";
            book2.Pages = "Demo Pages 2";
            book2.Keywords = "Demo Keywords 2";
            book2.Editors.Add("Demo Editors ");
            book2.Publisher = "Demo Publisher 2";
            book2.URL = "Demo URL 2";
            book2.CatalogIDS = "Demo Catalog IDS 2";
            book2.Price = "Demo Price 2";
            book2.Location = "Demo Location 2";
            book2.Status = "Demo Status 2";
            book2.GivenDatetime = "Demo Given Datetime 2";
            book2.ReturnDatetime = "Demo Return Datetime 2";


            Book book3 = new Book();
            book3.Id = "7";
            book3.Title = "Demo Title 3";
            book3.Description = "Demo Description 3";
            book3.Authors.Add("Demo Author 5");
            book3.Authors.Add("Demo Author 6");
            book3.Categories.Add("ScienceFiction");
            book3.Categories.Add("Drama");
            book3.Year = "Demo Year 2";
            book3.City = "Demo City 2";
            book3.Pages = "Demo Pages 2";
            book3.Keywords = "Demo Keywords 2";
            book3.Editors.Add("Demo Editors ");
            book3.Publisher = "Demo Publisher 2";
            book3.URL = "Demo URL 2";
            book3.CatalogIDS = "Demo Catalog IDS 2";
            book3.Price = "Demo Price 2";
            book3.Location = "Demo Location 2";
            book3.Status = "Demo Status 2";
            book3.GivenDatetime = "Demo Given Datetime 2";
            book3.ReturnDatetime = "Demo Return Datetime 2";


            byte[] bookBytes1 = Book.BookToByteArrayBlock(book1);
            byte[] bookBytes2 = Book.BookToByteArrayBlock(book2);
            byte[] bookBytes3 = Book.BookToByteArrayBlock(book3);

            FileUtility.AppendBlock(bookBytes1, "C:\\Users\\Ali\\Desktop\\ce103 - hw3 - ali - emre\\Library.dat");
            FileUtility.AppendBlock(bookBytes2, "C:\\Users\\Ali\\Desktop\\ce103 - hw3 - ali - emre\\Library.dat");
            FileUtility.AppendBlock(bookBytes3, "C:\\Users\\Ali\\Desktop\\ce103 - hw3 - ali - emre\\Library.dat");

            byte[] bookWrittenBytes = FileUtility.ReadBlock(2, Book.BOOK_DATA_BLOCK_SIZE, "C:\\Users\\Ali\\Desktop\\ce103 - hw3 - ali - emre\\Library.dat");
            Book bookWrittenObject = Book.ByteArrayBlockToBook(bookWrittenBytes);



    
        }
    }

}
