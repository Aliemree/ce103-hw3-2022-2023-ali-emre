using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw3_library_lib
{
    public class Book
    {
        public const int ID_MAX_LENGTH = 4;

        public const int TITLE_MAX_LENGTH = 100;

        public const int DESCRIPTION_MAX_LENGTH = 300;

        public const int AUTHORS_MAX_COUNT = 5;
        public const int AUTHORS_NAME_MAX_LENGTH = 100;

        public const int CATEGORY_MAX_COUNT = 5;
        public const int CATEGORY_NAME_MAX_LENGTH = 100;

        public const int YEAR_MAX_LENGTH = 4;

        public const int CITY_MAX_LENGTH = 100;

        public const int PAGES_MAX_LENGTH = 5;

        public const int KEYWORDS_MAX_LENGTH = 100;

        public const int EDITORS_MAX_COUNT = 5;
        public const int EDITORS_MAX_LENGTH = 100;

        public const int PUBLISHER_MAX_LENGTH = 100;

        public const int URL_MAX_LENGTH = 1000;

        public const int CATALOGIDS_MAX_LENGTH = 4;

        public const int PRICE_MAX_LENGTH = 5;

        public const int LOCATION_MAX_LENGTH = 1000;

        public const int STATUS_MAX_LENGTH = 1000;

        public const int GIVENDATETIME_MAX_LENGTH = 8;

        public const int RETURNDATETIME_MAX_LENGTH = 8;

        public const int BOOK_DATA_BLOCK_SIZE = ID_MAX_LENGTH +
                                                TITLE_MAX_LENGTH +
                                                DESCRIPTION_MAX_LENGTH +
                                                (AUTHORS_MAX_COUNT * AUTHORS_NAME_MAX_LENGTH) +
                                                (CATEGORY_MAX_COUNT * CATEGORY_NAME_MAX_LENGTH) +
                                                (YEAR_MAX_LENGTH) +
                                                (CITY_MAX_LENGTH) +
                                                (PAGES_MAX_LENGTH) +
                                                (KEYWORDS_MAX_LENGTH) +
                                                (EDITORS_MAX_COUNT * EDITORS_MAX_LENGTH) +
                                                (PUBLISHER_MAX_LENGTH) +
                                                (URL_MAX_LENGTH) +
                                                (CATALOGIDS_MAX_LENGTH) +
                                                (PRICE_MAX_LENGTH) +
                                                (LOCATION_MAX_LENGTH) +
                                                (STATUS_MAX_LENGTH) +
                                                (GIVENDATETIME_MAX_LENGTH) +
                                                (RETURNDATETIME_MAX_LENGTH);

                                                  
        private string _id;
        private string _title;
        private string _description;
        private List<string> _authors;
        private List<string> _categories;
        private string _year;
        private string _city;
        private string _pages;
        private string _keywords;
        private List<string> _editors;
        private string _publisher;
        private string _url;
        private string _catalogıds;
        private string _price;
        private string _location;
        private string _status;
        private string _givendatetime;
        private string _returndatetime;
        public string Id { get { return _id; } set { _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public List<string> Authors { get { return _authors; } set { _authors = value; } }
        public List<string> Categories { get { return _categories; } set { _categories = value; } }
        public string Year { get { return _year; } set { _year = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public string Pages { get { return _pages; } set { _pages = value; } }
        public string Keywords { get { return _keywords; } set { _keywords = value; } }
        public List<string> Editors { get { return _editors; } set { _editors = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public string URL { get { return _url; } set { _url = value; } }
        public string CatalogIDS { get { return _catalogıds; } set { _catalogıds = value; } }
        public string Price { get { return _price; } set { _price = value; } }
        public string Location { get { return _location; } set { _location = value; } }
        public string Status { get { return _status; } set { _status = value; } }
        public string GivenDatetime { get { return _givendatetime; } set { _givendatetime = value; } }
        public string ReturnDatetime { get { return _returndatetime; } set { _returndatetime = value; } }

        public Book()
        {
            _authors = new List<string>();
            _categories = new List<string>();
            _editors = new List<string>();
        }

        public static byte[] BookToByteArrayBlock(Book book)
        {
            int index = 0;

            byte[] dataBuffer = new byte[BOOK_DATA_BLOCK_SIZE];

            byte[] idBytes = ConversionUtility.StringToByteArray(book.Id);
            Array.Copy(idBytes, 0, dataBuffer, index, idBytes.Length);
            index += Book.ID_MAX_LENGTH;

            byte[] titleBytes = ConversionUtility.StringToByteArray(book.Title);
            Array.Copy(titleBytes, 0, dataBuffer, index, titleBytes.Length);
            index += Book.TITLE_MAX_LENGTH;

            byte[] descBytes = ConversionUtility.StringToByteArray(book.Description);
            Array.Copy(descBytes, 0, dataBuffer, index, descBytes.Length);
            index += Book.DESCRIPTION_MAX_LENGTH;

            byte[] authorBytes = ConversionUtility.StringListToByteArray(book.Authors,
                                                                            Book.AUTHORS_MAX_COUNT,
                                                                            Book.AUTHORS_NAME_MAX_LENGTH);
            Array.Copy(authorBytes, 0, dataBuffer, index, authorBytes.Length);
            index += authorBytes.Length;

            byte[] categoryBytes = ConversionUtility.StringListToByteArray(book.Categories,
                                                                            Book.CATEGORY_MAX_COUNT,
                                                                            Book.CATEGORY_NAME_MAX_LENGTH);
            Array.Copy(categoryBytes, 0, dataBuffer, index, categoryBytes.Length);
            index += categoryBytes.Length;

            byte[] yearBytes = ConversionUtility.StringToByteArray(book.Year);
            Array.Copy(yearBytes, 0, dataBuffer, index, yearBytes.Length);
            index += Book.YEAR_MAX_LENGTH;

            byte[] cityBytes = ConversionUtility.StringToByteArray(book.City);
            Array.Copy(cityBytes, 0, dataBuffer, index, cityBytes.Length);
            index += Book.CITY_MAX_LENGTH;

            byte[] pagesBytes = ConversionUtility.StringToByteArray(book.Pages);
            Array.Copy(pagesBytes, 0, dataBuffer, index, pagesBytes.Length);
            index += Book.PAGES_MAX_LENGTH;

            byte[] keywordsBytes = ConversionUtility.StringToByteArray(book.Keywords);
            Array.Copy(keywordsBytes, 0, dataBuffer, index, keywordsBytes.Length);
            index += Book.KEYWORDS_MAX_LENGTH;

            byte[] EditorsBytes = ConversionUtility.StringListToByteArray(book.Editors,
                                                                            Book.EDITORS_MAX_COUNT,
                                                                            Book.EDITORS_MAX_LENGTH);
            Array.Copy(EditorsBytes, 0, dataBuffer, index, EditorsBytes.Length);
            index += EditorsBytes.Length;

            byte[] PublisherBytes = ConversionUtility.StringToByteArray(book.Publisher);
            Array.Copy(PublisherBytes, 0, dataBuffer, index, PublisherBytes.Length);
            index += Book.PUBLISHER_MAX_LENGTH;

            byte[] UrlBytes = ConversionUtility.StringToByteArray(book.URL);
            Array.Copy(UrlBytes, 0, dataBuffer, index, UrlBytes.Length);
            index += Book.URL_MAX_LENGTH;

            byte[] CatalogidsBytes = ConversionUtility.StringToByteArray(book.CatalogIDS);
            Array.Copy(CatalogidsBytes, 0, dataBuffer, index, CatalogidsBytes.Length);
            index += Book.CATALOGIDS_MAX_LENGTH;

            byte[] PriceBytes = ConversionUtility.StringToByteArray(book.Price);
            Array.Copy(PriceBytes, 0, dataBuffer, index, PriceBytes.Length);
            index += Book.PRICE_MAX_LENGTH;

            byte[] LocationBytes = ConversionUtility.StringToByteArray(book.Location);
            Array.Copy(LocationBytes, 0, dataBuffer, index, LocationBytes.Length);
            index += Book.LOCATION_MAX_LENGTH;

            byte[] StatusBytes = ConversionUtility.StringToByteArray(book.Status);
            Array.Copy(StatusBytes, 0, dataBuffer, index, StatusBytes.Length);
            index += Book.STATUS_MAX_LENGTH;

            byte[] GivendatetimeBytes = ConversionUtility.StringToByteArray(book.GivenDatetime);
            Array.Copy(GivendatetimeBytes, 0, dataBuffer, index, GivendatetimeBytes.Length);
            index += Book.GIVENDATETIME_MAX_LENGTH;

            byte[] ReturndatetimeBytes = ConversionUtility.StringToByteArray(book.ReturnDatetime);
            Array.Copy(ReturndatetimeBytes, 0, dataBuffer, index, ReturndatetimeBytes.Length);
            index += Book.RETURNDATETIME_MAX_LENGTH;



            if (index != dataBuffer.Length)
            {
                throw new ArgumentException("Index and DataBuffer Size Not Matched");
            }

            return dataBuffer;
        }
        public static Book ByteArrayBlockToBook(byte[] byteArray)
        {

            Book book = new Book();

            if (byteArray.Length != BOOK_DATA_BLOCK_SIZE)
            {
                throw new ArgumentException("Byte Array Size Not Match with Constant Data Block Size");
            }

            int index = 0;

            byte[] dataBuffer = new byte[BOOK_DATA_BLOCK_SIZE];

            byte[] idBytes = new byte[Book.ID_MAX_LENGTH];
            Array.Copy(byteArray, index, idBytes, 0, idBytes.Length);
            book.Id = ConversionUtility.ByteArrayToString(idBytes);

            index += Book.ID_MAX_LENGTH;

            byte[] titleBytes = new byte[Book.TITLE_MAX_LENGTH];
            Array.Copy(byteArray, index, titleBytes, 0, titleBytes.Length);
            book.Title = ConversionUtility.ByteArrayToString(titleBytes);

            index += Book.TITLE_MAX_LENGTH;

            byte[] descBytes = new byte[Book.DESCRIPTION_MAX_LENGTH];
            Array.Copy(byteArray, index, descBytes, 0, descBytes.Length);
            book.Description = ConversionUtility.ByteArrayToString(descBytes);

            index += Book.DESCRIPTION_MAX_LENGTH;

            byte[] authorBytes = new byte[Book.AUTHORS_MAX_COUNT * Book.AUTHORS_NAME_MAX_LENGTH];

            Array.Copy(byteArray, index, authorBytes, 0, authorBytes.Length);

            book.Authors = ConversionUtility.ByteArrayToStringList(authorBytes,
                                                                            Book.AUTHORS_MAX_COUNT,
                                                                            Book.AUTHORS_NAME_MAX_LENGTH);

            index += authorBytes.Length;

            byte[] categoryBytes = new byte[Book.CATEGORY_MAX_COUNT * Book.CATEGORY_NAME_MAX_LENGTH];

            Array.Copy(byteArray, index, categoryBytes, 0, categoryBytes.Length);

            book.Categories = ConversionUtility.ByteArrayToStringList(categoryBytes,
                                                                            Book.CATEGORY_MAX_COUNT,
                                                                            Book.CATEGORY_NAME_MAX_LENGTH);

            index += categoryBytes.Length;

            byte[] yearBytes = new byte[Book.YEAR_MAX_LENGTH];
            Array.Copy(byteArray, index, idBytes, 0, yearBytes.Length);
            book.Year = ConversionUtility.ByteArrayToString(yearBytes);

            index += Book.YEAR_MAX_LENGTH;

            byte[] cityBytes = new byte[Book.CITY_MAX_LENGTH];
            Array.Copy(byteArray, index, cityBytes, 0, cityBytes.Length);
            book.City = ConversionUtility.ByteArrayToString(cityBytes);

            index += Book.CITY_MAX_LENGTH;

            byte[] pagesBytes = new byte[Book.PAGES_MAX_LENGTH];
            Array.Copy(byteArray, index, pagesBytes, 0, pagesBytes.Length);
            book.Pages = ConversionUtility.ByteArrayToString(pagesBytes);

            index += Book.PAGES_MAX_LENGTH;

            byte[] keywordsBytes = new byte[Book.CITY_MAX_LENGTH];
            Array.Copy(byteArray, index, keywordsBytes, 0, keywordsBytes.Length);
            book.Keywords = ConversionUtility.ByteArrayToString(keywordsBytes);

            index += Book.KEYWORDS_MAX_LENGTH;

            byte[] editorsBytes = new byte[Book.EDITORS_MAX_COUNT * Book.EDITORS_MAX_LENGTH];

            Array.Copy(byteArray, index, editorsBytes, 0, editorsBytes.Length);

            book.Editors = ConversionUtility.ByteArrayToStringList(editorsBytes,
                                                                            Book.EDITORS_MAX_COUNT,
                                                                            Book.EDITORS_MAX_LENGTH);

            index += editorsBytes.Length;

            byte[] publisherBytes = new byte[Book.PUBLISHER_MAX_LENGTH];
            Array.Copy(byteArray, index, publisherBytes, 0, publisherBytes.Length);
            book.Publisher = ConversionUtility.ByteArrayToString(publisherBytes);

            index += Book.PUBLISHER_MAX_LENGTH;

            byte[] urlBytes = new byte[Book.URL_MAX_LENGTH];
            Array.Copy(byteArray, index, urlBytes, 0, urlBytes.Length);
            book.URL = ConversionUtility.ByteArrayToString(urlBytes);

            index += Book.URL_MAX_LENGTH;

            byte[] catalogıdsBytes = new byte[Book.CATALOGIDS_MAX_LENGTH];
            Array.Copy(byteArray, index, pagesBytes, 0, catalogıdsBytes.Length);
            book.CatalogIDS = ConversionUtility.ByteArrayToString(catalogıdsBytes);

            index += Book.CATALOGIDS_MAX_LENGTH;

            byte[] priceBytes = new byte[Book.PRICE_MAX_LENGTH];
            Array.Copy(byteArray, index, priceBytes, 0, priceBytes.Length);
            book.Price = ConversionUtility.ByteArrayToString(priceBytes);

            index += Book.PRICE_MAX_LENGTH;

            byte[] locationBytes = new byte[Book.LOCATION_MAX_LENGTH];
            Array.Copy(byteArray, index, locationBytes, 0, locationBytes.Length);
            book.Location = ConversionUtility.ByteArrayToString(publisherBytes);

            index += Book.LOCATION_MAX_LENGTH;

            byte[] statusBytes = new byte[Book.STATUS_MAX_LENGTH];
            Array.Copy(byteArray, index, statusBytes, 0, statusBytes.Length);
            book.Status = ConversionUtility.ByteArrayToString(statusBytes);

            index += Book.STATUS_MAX_LENGTH;

            byte[] givendatetimeBytes = new byte[Book.GIVENDATETIME_MAX_LENGTH];
            Array.Copy(byteArray, index, givendatetimeBytes, 0, givendatetimeBytes.Length);
            book.GivenDatetime = ConversionUtility.ByteArrayToString(givendatetimeBytes);

            index += Book.GIVENDATETIME_MAX_LENGTH;

            byte[] returndatetimeBytes = new byte[Book.RETURNDATETIME_MAX_LENGTH];
            Array.Copy(byteArray, index, returndatetimeBytes, 0, returndatetimeBytes.Length);
            book.ReturnDatetime = ConversionUtility.ByteArrayToString(returndatetimeBytes);

            index += Book.RETURNDATETIME_MAX_LENGTH;


            if (index != byteArray.Length)
            {
                throw new ArgumentException("Index and DataBuffer Size Not Matched");
            }

            if (book.Id == "0")
            {
                return null;
            }
            else
            {
                return book;
            }

        }
    }
}
