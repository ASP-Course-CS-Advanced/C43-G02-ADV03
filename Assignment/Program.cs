namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            //Check Demo Branch

            #endregion

            #region Part02

            #region Using User-Define Delegate BookDelegate1.

            //List<Book1> books = new List<Book1>()
            //{
            //    new Book1("0x1000", "CS", ["Ahmed", "Eslam"], new DateTime(2002, 7, 1), 1500),
            //    new Book1("0x1002", "Ai", ["Riham", "Amir","Khalid"], new DateTime(2015, 7, 7), 1400),
            //    new Book1("0x1050", "Ds", ["Samir", "Ahd"], new DateTime(2020, 4, 8), 1000),
            //    new Book1("0x1800", "VR", ["Salma"], new DateTime(2024, 10, 1), 1505)

            //};

            //BookDelegate1 bookDelegate = new BookDelegate1(BookFunctions1.GetAuthors);

            //LibraryEngine1.ProcessBooks(books, bookDelegate);
            //// CS Book => Ahmed, Eslam
            //// Ai Book => Riham, Amir, Khalid
            //// Ds Book => Samir, Ahd
            //// VR Book => Salma

            #endregion

            #region Using BuiltIn-Delegate Func<Book1,string>

            //List<Book1> books = new List<Book1>()
            //{
            //    new Book1("0x1000", "CS", ["Ahmed", "Eslam"], new DateTime(2002, 7, 1), 1500),
            //    new Book1("0x1002", "Ai", ["Riham", "Amir","Khalid"], new DateTime(2015, 7, 7), 1400),
            //    new Book1("0x1050", "Ds", ["Samir", "Ahd"], new DateTime(2020, 4, 8), 1000),
            //    new Book1("0x1800", "VR", ["Salma"], new DateTime(2024, 10, 1), 1505)

            //};

            //Func<Book1, string> func = BookFunctions1.GetPrice;
            //LibraryEngine1.ProcessBooks(books, func);
            //// CS Book => 1500
            //// Ai Book => 1400
            //// Ds Book => 1000
            //// VR Book => 1505

            #endregion

            #region Using Anonymous Method

            //List<Book1> books = new List<Book1>()
            //{
            //    new Book1("0x1000", "CS", ["Ahmed", "Eslam"], new DateTime(2002, 7, 1), 1500),
            //    new Book1("0x1002", "Ai", ["Riham", "Amir","Khalid"], new DateTime(2015, 7, 7), 1400),
            //    new Book1("0x1050", "Ds", ["Samir", "Ahd"], new DateTime(2020, 4, 8), 1000),
            //    new Book1("0x1800", "VR", ["Salma"], new DateTime(2024, 10, 1), 1505)

            //};

            //LibraryEngine1.ProcessBooks(books, delegate (Book1 book) { return book.ISBN; });
            //// CS Book => 0x1000
            //// Ai Book => 0x1002
            //// Ds Book => 0x1050
            //// VR Book => 0x1800

            #endregion

            #region Using Lambda Expression

            //List<Book1> books = new List<Book1>()
            //{
            //    new Book1("0x1000", "CS", ["Ahmed", "Eslam"], new DateTime(2002, 7, 1), 1500),
            //    new Book1("0x1002", "Ai", ["Riham", "Amir","Khalid"], new DateTime(2015, 7, 7), 1400),
            //    new Book1("0x1050", "Ds", ["Samir", "Ahd"], new DateTime(2020, 4, 8), 1000),
            //    new Book1("0x1800", "VR", ["Salma"], new DateTime(2024, 10, 1), 1505)

            //};

            //LibraryEngine1.ProcessBooks(books, book => book.PublicationDate.ToLongDateString());
            //// CS Book => Monday, July 1, 2002
            //// Ai Book => Tuesday, July 7, 2015
            //// Ds Book => Wednesday, April 8, 2020
            //// VR Book => Tuesday, October 1, 2024

            #endregion

            #endregion

            #region Part03

            //MyList<int> myList = new MyList<int>();
            //myList.Add(10);
            //myList.Add(20);
            //myList.Add(30);
            //myList.Add(40);


            #region Exists()

            //Console.WriteLine(myList.Exists(x => x == 20)); // True

            #endregion

            #region Find()

            //Console.WriteLine(myList.Find(x => x == 30)); // 30 

            #endregion

            #region FindAll()

            //MyList<int> evenNumbers = myList.FindAll(x => x % 2 == 0);
            //Console.WriteLine(string.Join(",", evenNumbers));// 10,20,30,40

            #endregion

            #region FindIndex()

            //Console.WriteLine(myList.FindIndex(x => x == 30)); // 2 

            #endregion

            #region FindLast()

            //Console.WriteLine(myList.FindLast(x => x > 20)); // 40 

            #endregion

            #region FindLastIndex()

            //Console.WriteLine(myList.FindLastIndex(x => x == 20)); // 1 

            #endregion

            #region ForEach()

            //myList.ForEach(x => Console.Write($"{x} ")); // 10 20 30 40 
            //Console.WriteLine();

            #endregion

            #region TrueForAll

            //Console.WriteLine(myList.TrueForAll(x => x > 0)); // True 

            #endregion


            #endregion

            #region Part03

            //MyList1<int> numbers = new MyList1<int>();
            //numbers.Add(-1);
            //numbers.Add(-5);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(5);
            //numbers.Add(6);

            #region Exist()

            //Console.WriteLine(numbers.Exist(x => x % 2 == 0));//True

            #endregion

            #region Find()

            //int FirstOddNumber = numbers.Find(X => X % 2 != 0);
            //Console.WriteLine(FirstOddNumber);//3

            #endregion

            #region FindAll()

            //MyList<int> newList = numbers.FindAll(X => X % 2 == 0);
            //Console.WriteLine(string.Join(", ",newList));// 0, 2, 4, 6

            #endregion

            #region FindIndex()

            //int firstEvenIndex = numbers.FindIndex(X => X % 2 == 0);
            //Console.WriteLine(firstEvenIndex);//3

            #endregion

            #region FindLast()

            //int LastEven = numbers.FindLast(X => X % 2 == 0);
            //Console.WriteLine(LastEven);//6

            #endregion

            #region FindLastIndex()

            //int LastOddIndex = numbers.FindLastIndex(X => X % 2 == 1);
            //Console.WriteLine(LastOddIndex);//4

            #endregion

            #region ForEach()

            //numbers.ForEach(X => Console.Write($"{X + 1} "));// 0 -4 4 5 6 7

            #endregion

            #region TrueForAll()

            //bool AllNumbersPositive = numbers.TrueForAll(X => X > 0);
            //Console.WriteLine(AllNumbersPositive);//False

            #endregion

            #endregion

        }
    }
}
