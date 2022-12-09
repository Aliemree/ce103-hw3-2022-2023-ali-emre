using ce103_hw3_library_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw3_library_app
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library();
            myLibrary.Password();
        }

        public void BookTest()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string filename = Path.Combine(path, "library.dat");

            Book book1 = new Book();
            book1.Id = "5";
            book1.Title = "Demo Title 1";
            book1.Description = "Demo Description 1";
            book1.Authors.Add("Demo Author 1");
            book1.Categories.Add("ScienceFiction");
            book1.Categories.Add("Drama");
            book1.Year ="Demo Year";
            book1.City = "Demo City";
            book1.Pages = "Demo Pages";
            book1.Keywords = "Demo Keywords";
            book1.Editors.Add("Demo Editors");
            book1.Publisher = "Demo Publisher";
            book1.URL = "Demo URL";
            book1.CatalogIDS = "Demo Catalog IDS";





            Book book2 = new Book();
            book2.Id = "6";
            book2.Title = "Demo Title 2";
            book2.Description = "Demo Description 2";
            book2.Authors.Add("Demo Author 3");
            book2.Authors.Add("Demo Author 4");
            book2.Categories.Add("ScienceFiction");
            book2.Categories.Add("Drama");
            Book book3 = new Book();

            book3.Id = "7";
            book3.Title = "Demo Title 3";
            book3.Description = "Demo Description 3";
            book3.Authors.Add("Demo Author 5");
            book3.Authors.Add("Demo Author 6");
            book3.Categories.Add("ScienceFiction");
            book3.Categories.Add("Drama");

            byte[] bookBytes1 = Book.BookToByteArrayBlock(book1);
            byte[] bookBytes2 = Book.BookToByteArrayBlock(book2);
            byte[] bookBytes3 = Book.BookToByteArrayBlock(book3);

            FileUtility.AppendBlock(bookBytes1, filename);
            FileUtility.AppendBlock(bookBytes2, filename);
            FileUtility.AppendBlock(bookBytes3, filename);

            byte[] bookWrittenBytes = FileUtility.ReadBlock(2, Book.BOOK_DATA_BLOCK_SIZE, filename);
            Book bookWrittenObject = Book.ByteArrayBlockToBook(bookWrittenBytes);


        }
    }
}
