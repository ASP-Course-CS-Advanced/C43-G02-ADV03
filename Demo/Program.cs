namespace Demo
{
    //Step 00  - [Define Delegate].
    public delegate int StringFuncDelegate(string s);// This line compiled as a class which has some methods and constructor
                                                     // in compilation time (IL code).
    /// New Delegate
    /// Reference from this delegate/class "StringFuncDelegate" can refer/HoldAddress
    /// of function or more [pointer to function or more]
    /// this function could be static [class member] or nonStatic [object member].
    /// those function or functions that this reference from delegate will refer to 
    /// must be with the same signature of the delegate [Return Type && Parameters Type && number of parameters].
    /// Regardless Function name or parameter name or access modifiers
    /// Like in this case -> Reference from this delegate "StringFuncDelegate" could refer only to function that return "int"
    /// and take only one parameter of type "string". 

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 02 Delegate Example 01

            ////Step 01 - Declare Reference from delegate "StringFuncDelegate".

            //StringFuncDelegate? stringFunc;// Contain Garbage value now.

            ////Step 02 - Initialize this reference with object of type "StringFuncDelegate" 
            ////which has constructor that take any function "target function" that return "int" and take one parameter of type "string".

            ////stringFunc = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChar);
            //stringFunc = StringFunctions.GetCountOfUpperCaseChar;//Syntax Sugar for previous line.
            ////Now, The Reference "stringFunc" in STACk, Hold Address of the object of type "StringFuncDelegate" which
            ////Contain the function "GetCountOfUpperCaseChar" that take "string" parameter and return "int" value. 

            ////stringFunc = new StringFuncDelegate(StringFunctions.GetCountOfLowerCaseChar);//Make the reference "stringFunc" refer to a new object in heap that contain new method "GetCountOfLowerCaseChar".
            //stringFunc = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChar) + new StringFuncDelegate(StringFunctions.GetCountOfLowerCaseChar);
            ////stringFunc += new StringFuncDelegate(StringFunctions.GetCountOfLowerCaseChar);
            ////Make The Reference "stringFunc" Hold Address of 2 objects contains two methods "GetCountOfUpperCaseChar", "GetCountOfLowerCaseChar".

            ////stringFunc -= new StringFuncDelegate(StringFunctions.GetCountOfLowerCaseChar);// To Make the reference "stringFunc" leave holding address of function "GetCountOfLowerCaseChar" and hold only address of another function in the object in heap.

            ////Step 03 - Use The Reference from the delegate that hold address of object contain method return int and take string
            ////To call the method.
            ////delegate class has some methods like Invoke() that take parameter of type same with the function that the reference from the delegate refer to.

            //int result = stringFunc?.Invoke("EslaM ElsaadanY") ?? -1;// Invoke the 2 methods that "stringFunc" refer to and execute them, but return the result of the last method that it refer to which is "GetCountOfLowerCaseChar". 
            ////result = stringFunc("EslaM ElsaadanY");//Syntax Sugar. 

            //Console.WriteLine(result);//10 

            #endregion

            #region Part 03 Delegate Example 02

            #region Before using Delegate as a parameter - BubbleSort(int[] arr)

            //int[] numbers = new int[] { 7, 5, 6, 9, 8, 7, 5, 2, 3, 1 };
            //SortingAlgorithms.BubbleSort(numbers);

            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} ");// 1 2 3 5 5 6 7 7 8 9
            //} 
            #endregion

            #region using delegate as a parameter that could refer to any function that take 2 int parameters and return bool - BubbleSort(int[] arr,SortingTypesFuncDelegate sortingType)

            #region Sort Asc - BubbleSort(numbers, SortingTypes.CompareGreater)

            //int[] numbersAsc = new int[] { 7, 5, 6, 9, 8, 7, 5, 2, 3, 1 };
            //SortingAlgorithms.BubbleSort(numbersAsc, SortingTypes.CompareGreater);

            //foreach (var item in numbersAsc)
            //{
            //    Console.Write($"{item} ");// 1 2 3 5 5 6 7 7 8 9

            //}
            //Console.WriteLine();

            #endregion

            #region Sort Desc - BubbleSort(numbers, sortDesc)

            //int[] numbersDesc = new int[] { 7, 5, 6, 9, 8, 7, 5, 2, 3, 1 };
            //SortingTypesFuncDelegate sortDesc = new SortingTypesFuncDelegate(SortingTypes.CompareLess);
            //sortDesc = null;
            //SortingAlgorithms.BubbleSort(numbersDesc, sortDesc);

            //foreach (var item in numbersDesc)
            //{
            //    Console.Write($"{item} ");// 1 2 3 5 5 6 7 7 8 9

            //}

            #endregion

            #endregion

            ///Invalid Approach
            ///SortingAlgorithms.BubbleSortDesc(numbers);
            ///
            ///foreach (var item in numbers)
            ///{
            ///    Console.Write($"{item} ");// 9 8 7 7 6 5 5 3 2 1
            ///}

            #endregion

        }
    }
}
