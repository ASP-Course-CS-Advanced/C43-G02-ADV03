using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Demo
{
    internal static class TestBuiltInDelegates
    {

        public static bool CheckPositive(int number) => number > 0;

        public static string CastInt(int number) => number.ToString();

        public static void Print() => Console.WriteLine("Hello World!");

        public static void Print(string name) => Console.WriteLine($"Hello {name}!");
    }
}
