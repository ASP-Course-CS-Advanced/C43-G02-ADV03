using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Book1
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book1(string _Isbn, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _Isbn;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {
            return $"ISBN:{ISBN}, Title: {Title}, Authors: {Authors}, PublicationDate: {PublicationDate}, Price: {Price}";
        }
    }
}
