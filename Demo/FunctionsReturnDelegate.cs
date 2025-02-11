using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class FunctionsReturnDelegate
    {

        public static Action DelegateAction()
        {
            //Anonymous Method
            return delegate () { Console.WriteLine("Hello World!"); };

            ////Lambda Expression
            ////return () => Console.WriteLine("Hello World!");
        }

        public static Predicate<int> DelegatePredicate()
        {
            return delegate (int num) { return num % 2 == 0; };
        }

        public static Func<char[], string> DelegateFunc()
        {
            return delegate (char[] x) { return new string(x); };
        }

    }
}
