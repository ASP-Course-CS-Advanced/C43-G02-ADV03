using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class SortingTypes
    {
        //if(arr[j] > arr[j + 1]) -> SWAP(ref arr[j],arr[j+1])  "Sorting Asc"
        public static bool SortAsc(int x, int y)
        {
            return x > y;
        }

        public static bool SortAsc(string x, string y)
        {
            return x.Length > y.Length;
        }

        //if(arr[j] < arr[j + 1]) -> SWAP(ref arr[j],arr[j+1])  "Sorting Desc"
        public static bool SortDesc(int x, int y)
        {
            return x < y;
        }

        public static bool SortDesc(string x, string y)
        {
            return x.Length < y.Length;
        }


    }
}
