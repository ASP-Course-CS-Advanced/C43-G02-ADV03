using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal delegate string BookDelegate1(Book1 book);

    internal class LibraryEngine1
    {

        //public static void ProcessBooks(List<Book1> bookList, BookDelegate1 book)
        //{
        //    foreach (Book1 B in bookList)
        //    {
        //        Console.WriteLine($"{B.Title} Book => {book.Invoke(B)}");
        //    }
        //}

        public static void ProcessBooks(List<Book1> bookList, Func<Book1, string> book)
        {
            foreach (Book1 B in bookList)
            {
                Console.WriteLine($"{B.Title} Book => {book.Invoke(B)}");
            }
        }
    }
}
