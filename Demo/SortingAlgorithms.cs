using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //Non Generic Delegate [Can hold only address of any function that take 2 parameters of type int only and return bool]
    //public delegate bool SortingTypesFuncDelegate<T>(T x, T y);
    
    //Generic Delegate [Can hold address of any function that take 2 parameters of anyType and return bool]
    public delegate Tout SortingTypesFuncDelegate<in T,in T2,out Tout>(T x, T2 y);

    internal static class SortingAlgorithms<T>
    {
        private static void SWAP(ref T v1, ref T v2)
        {
            T temp = v1;
            v1 = v2;
            v2 = temp;
        }

        public static void BubbleSort(T[] arr, SortingTypesFuncDelegate<T,T,bool> sortingType)//Same T[Type], Because the delegate will refer to methods take parameters of same type.
        {
            if (arr?.Length > 0 && sortingType is not null)
                for (int i = 0; i < arr.Length; i++)
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                        //if (arr[j] > arr[j + 1])
                        if (sortingType.Invoke(arr[j], arr[j + 1]))// Delegate the choose of sorting Asc or Desc to the based in the function that will passed as parameter to this function by the user
                                                                   // as that reference from delegate could refer to addrees of function that take 2 parameters of type "int" and return "bool"
                            SWAP(ref arr[j], ref arr[j + 1]);
        } 
        
        //Using Built In Delegate Func, that reference from it could refer to function take from 1 - 16 paramneter of any type and return any type.
        public static void BubbleSortv02(T[] arr, Func<T,T,bool> sortingType)
        {
            if (arr?.Length > 0 && sortingType is not null)
                for (int i = 0; i < arr.Length; i++)
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                        //if (arr[j] > arr[j + 1])
                        if (sortingType.Invoke(arr[j], arr[j + 1]))                                         
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
