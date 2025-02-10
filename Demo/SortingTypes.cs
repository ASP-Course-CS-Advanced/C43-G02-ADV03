using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class SortingTypes
    {
        //arr[j] > arr[j + 1] "Sorting Asc"
        public static bool CompareGreater(int x,int y)
        {
            return x > y;
        }

        //arr[j] < arr[j + 1] "Sorting Desc"
        public static bool CompareLess(int x,int y)
        {
            return x < y;
        }
    }
}
