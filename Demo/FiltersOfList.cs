using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class FiltersOfList
    {
        //Lambda Expression Syntax.
        public static bool CheckOdd(int number) => number % 2 == 1;

        public static bool CheckEven(int number) => number % 2 == 0;

        public static bool DivisibleBy7(int number) => number % 7 == 0;

        public static bool DivisibleByTen(int number) => number % 10 == 0;

        public static bool StringMoreThanThree(string str) => str?.Length > 3;

        public static bool StringLessThanFour(string str) => str?.Length < 4;

        public static bool StringMoreThanFour(string str) => str?.Length > 4;

    }
}
