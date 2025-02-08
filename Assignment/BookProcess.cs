using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal delegate string BookDelegate(Book B);

    internal class LibraryEngine
    {
        // User-Defined Delegate
        public static void ProcessBooks(List<Book> booklist, BookDelegate reference)
        {
            foreach (Book book in booklist)
            {
                Console.WriteLine(reference(book));
            }
        }

        // Built-in Delegate (Func<Book, string>)
        public static void ProcessBooks(List<Book> booklist, Func<Book, string> reference)
        {
            foreach (Book book in booklist)
            {
                Console.WriteLine(reference(book));
            }
        }
    }
}
