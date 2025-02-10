using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool SortingTypesFuncDelegate(int x, int y);

    internal static class SortingAlgorithms
    {
        private static void SWAP(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }

        public static void BubbleSort(int[] arr, SortingTypesFuncDelegate sortingType)
        {
            if (arr?.Length > 0 && sortingType is not null)
                for (int i = 0; i < arr.Length; i++)
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                        //if (arr[j] > arr[j + 1])
                        if (sortingType.Invoke(arr[j], arr[j + 1]))// Delegate the choose of sorting Asc or Desc to the based in the function that will passed as parameter to this function by the user
                                                                   // as that reference from delegate could refer to addrees of function that take 2 parameters of type "int" and return "bool"
                            SWAP(ref arr[j], ref arr[j + 1]);
        }

        ///Invalid Approach [Abuse Using Overloading - the two functions has the same body , the difference is just sign >,<]
        ///public static void BubbleSortDesc(int[] arr)
        ///{
        ///    if (arr?.Length > 0)
        ///        for (int i = 0; i < arr.Length; i++)
        ///            for (int j = 0; j < arr.Length - 1 - i; j++)
        ///                if (arr[j] < arr[j + 1])
        ///                    SWAP(ref arr[j], arr[j + 1]);
        ///}


    }
}
