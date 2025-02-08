namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part02

            //    List<Book> bookList = new List<Book>
            //{
            //    new Book("12345", "Cs Book", new string[] { "Eslam Elsaadany", "Ahmed Ashraf" }, new DateTime(2021, 1, 1), 150m),
            //    new Book("78910", "OOP Book", new string[] { "Khalid Nasr" }, new DateTime(2020, 2, 8), 149.99m)
            //};

            //    //User-Defined Delegate
            //    BookDelegate titleDelegate = new BookDelegate(BookFunctions.GetTitle);
            //    Console.WriteLine("User-Defined Delegate (GetTitle):");
            //    LibraryEngine.ProcessBooks(bookList, titleDelegate);

            //    //Built-in Delegate
            //    Func<Book, string> authorsDelegate = BookFunctions.GetAuthors;
            //    Console.WriteLine("\nBuilt-in Delegate (GetAuthors):");
            //    LibraryEngine.ProcessBooks(bookList, authorsDelegate);

            //    //Anonymous Method (GetISBN)
            //    BookDelegate isbnDelegate = delegate (Book B) { return B.ISBN; };
            //    Console.WriteLine("\nAnonymous Method (GetISBN):");
            //    LibraryEngine.ProcessBooks(bookList, isbnDelegate);

            //    //Lambda Expression (GetPublicationDate)
            //    Func<Book, string> publicationDateDelegate = B => B.PublicationDate.ToShortDateString();
            //    Console.WriteLine("\nLambda Expression (GetPublicationDate):");
            //    LibraryEngine.ProcessBooks(bookList, publicationDateDelegate);

            #endregion

            #region Part03

            MyList<int> myList = new MyList<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);


            #region Exists()

            Console.WriteLine(myList.Exists(x => x == 20)); // True

            #endregion

            #region Find()
            
            Console.WriteLine(myList.Find(x => x == 30)); // 30 

            #endregion

            #region FindAll()

            MyList<int> evenNumbers = myList.FindAll(x => x % 2 == 0);
            Console.WriteLine(string.Join(",", evenNumbers));// 10,20,30,40

            #endregion

            #region FindIndex()

            Console.WriteLine(myList.FindIndex(x => x == 30)); // 2 

            #endregion

            #region FindLast()

            Console.WriteLine(myList.FindLast(x => x > 20)); // 40 

            #endregion

            #region FindLastIndex()

            Console.WriteLine(myList.FindLastIndex(x => x == 20)); // 1 

            #endregion

            #region ForEach()
            
            myList.ForEach(x => Console.Write($"{x} ")); // 10 20 30 40 
            Console.WriteLine();

            #endregion

            #region TrueForAll
            
            Console.WriteLine(myList.TrueForAll(x => x > 0)); // True 

            #endregion


            #endregion

        }
    }
}
