using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class BookFunctions1
    {
        public static string GetTitle(Book1 book)
        {
            if (book is not null && book.Title is not null)
                return book.Title;
            else
                return $"book reference is null.";
        }

        public static string GetAuthors(Book1 book)
        {
            if (book is null || book.Authors is null)
                return $"No Authors!";
            return string.Join(", ", book.Authors);
        }
        
        public static string GetPrice(Book1 book)
        {
            if (book is null)
                return $"-1";
            return book.Price.ToString();
        }

    }
}
