using System.Net.NetworkInformation;
using System.Net.Security;

namespace Demo
{
    #region Part 02 Delegate Example 01

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


    #endregion

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
            ///Invalid Approach
            ///SortingAlgorithms.BubbleSortDesc(numbers);
            ///
            ///foreach (var item in numbers)
            ///{
            ///    Console.Write($"{item} ");// 9 8 7 7 6 5 5 3 2 1
            ///}

            #endregion

            #region Using delegate as a parameter that could refer to any function that take 2 int parameters and return bool - BubbleSort(int[] arr,SortingTypesFuncDelegate sortingType)

            #region Sort Asc - BubbleSort(numbers, SortingTypes.CompareGreater)

            //int[] numbersAsc = new int[] { 7, 5, 6, 9, 8, 7, 5, 2, 3, 1 };
            //SortingAlgorithms<int>.BubbleSort(numbersAsc, SortingTypes.SortAsc);

            //foreach (var item in numbersAsc)
            //{
            //    Console.Write($"{item} ");// 1 2 3 5 5 6 7 7 8 9

            //}
            //Console.WriteLine();

            #endregion

            #region Sort Desc - BubbleSort(numbers, sortDesc)

            //int[] numbersDesc = new int[] { 7, 5, 6, 9, 8, 7, 5, 2, 3, 1 };
            //SortingTypesFuncDelegate<int, int, bool> sortDesc = new SortingTypesFuncDelegate<int, int, bool>(SortingTypes.SortDesc);
            ////sortDesc = null;
            //SortingAlgorithms<int>.BubbleSort(numbersDesc, sortDesc);

            //foreach (var item in numbersDesc)
            //{
            //    Console.Write($"{item} ");// 9 8 7 7 6 5 5 3 2 1

            //}

            #endregion

            #endregion


            #endregion

            #region Part 04 Delegate Example 02 With Generics

            //string[] names = new string[]
            //{
            //    new string("Ahmed"),
            //    new string("Eslam"),
            //    new string("Khaled"),
            //    new string("Amir"),
            //    new string("Sama"),
            //    new string("Nono"),
            //    new string("Ali"),
            //    new string("Amr")
            //};

            #region Sort Asc Based On string Length[Pass Function Direct] - BubbleSort(names, SortingTypes.CompareGreater)

            //SortingAlgorithms<string>.BubbleSort(names, SortingTypes.SortAsc);
            //Console.WriteLine(string.Join(", ", names));

            #endregion

            #region Sort Desc Based on string Length [Pass Reference From Delegate That refer to function] - BubbleSort(names, sortingType).

            //SortingTypesFuncDelegate<string, string, bool> sortingType = new SortingTypesFuncDelegate<string, string, bool>(SortingTypes.SortDesc);

            //SortingAlgorithms<string>.BubbleSort(names, sortingType);
            //Console.WriteLine(string.Join(", ", names));

            #endregion

            #endregion

            #region Part 05 Delegate Example 03

            #region Before using Delegate as a parameter - List<int> oddNumbers = FilterLists.FindOddNumbers(numbers);

            //List<int> numbers = Enumerable.Range(1, 100).ToList();
            //List<int> oddNumbers = FilterLists.FindOddNumbers(numbers);
            //Console.WriteLine(string.Join(", ", oddNumbers));

            //Console.WriteLine(); 

            #region Invalid Approach.

            //List<int> EvenNumbers = FilterLists.FindEvenNumbers(numbers);
            //Console.WriteLine(string.Join(", ", EvenNumbers)); 

            #endregion

            #endregion

            #region Using delegate as a parameter that could refer to any function that take 1 int parameters and return bool - FindElement(List<int>[] numbers,FilterFuncDelegate FilterFunc)

            #region Find OddNumbers [Pass Function Direct] - List<int> oddNumbers = FilterLists.FindElements<int>(numbers, FiltersOfList.CheckOdd);

            //List<int> numbers = Enumerable.Range(1, 100).ToList();
            //List<int> oddNumbers = FilterLists.FindElements<int>(numbers, FiltersOfList.CheckOdd);

            //Console.WriteLine(string.Join(", ", oddNumbers));

            #endregion

            #region Find EvenNumbers[Pass Reference From Delegate That refer to function] - List<int> EvenNumbers = FilterLists.FindElements<int>(numbers, filterFuncDelegate);

            //List<int> numbers = Enumerable.Range(1, 100).ToList();
            //FilterFuncDelegate<int> filterFuncDelegate = new FilterFuncDelegate<int>(FiltersOfList.CheckEven);
            //List<int> EvenNumbers = FilterLists.FindElements<int>(numbers, filterFuncDelegate);

            //Console.WriteLine(string.Join(", ", EvenNumbers));

            #endregion

            #region Find DivisibleBy7 elements - List<int> DivisiblesBy7 = FilterLists.FindElements<int>(numbers, filterFuncDelegate);

            //List<int> numbers = Enumerable.Range(1, 100).ToList();
            //FilterFuncDelegate<int> filterFuncDelegate = new FilterFuncDelegate<int>(FiltersOfList.DivisibleBy7);
            //List<int> DivisiblesBy7 = FilterLists.FindElements<int>(numbers, filterFuncDelegate);

            //Console.WriteLine(string.Join(", ", DivisiblesBy7));//  7, 14, 21, 28, 35, 42, 49, 56, 63, 70, 77, 84, 91, 98

            #endregion

            #region Find DivisibleByTen elements - List<int> DivisiblesByTen = FilterLists.FindElements<int>(numbers, FiltersOfList.DivisibleByTen);

            //List<int> numbers = Enumerable.Range(1, 100).ToList();
            //List<int> DivisiblesByTen = FilterLists.FindElements<int>(numbers, FiltersOfList.DivisibleByTen);

            //Console.WriteLine(string.Join(", ", DivisiblesByTen));//  10, 20, 30, 40, 50, 60, 70, 80, 90, 100

            #endregion

            #region Find Strings More Than 3 Chars - List<string> namesMoreThan3 = FilterLists.FindElements<string>(names, FiltersOfList.StringMoreThanThree);


            //List<string> names = new List<string>()
            //{
            //    new string("Eslam"),
            //    new string("Ali"),
            //    new string("Amr"),
            //    new string("Ahd"),
            //    new string("Samir"),
            //    new string("Eman"),
            //};

            //List<string> namesMoreThan3 = FilterLists.FindElements<string>(names, FiltersOfList.StringMoreThanThree);

            //Console.WriteLine(string.Join(", ",namesMoreThan3));// Eslam, Samir, Eman

            #endregion

            #region Find Strings Less Than 4 Chars - List<string> namesLessThan4 = FilterLists.FindElements<string>(names, filterFuncDelegate);

            //List<string> names = new List<string>()
            //{
            //    new string("Eslam"),
            //    new string("Ali"),
            //    new string("Amr"),
            //    new string("Ahd"),
            //    new string("Samir"),
            //    new string("Eman"),
            //};

            //FilterFuncDelegate<string> filterFuncDelegate = new FilterFuncDelegate<string>(FiltersOfList.StringLessThanFour);
            //List<string> namesLessThan4 = FilterLists.FindElements<string>(names, filterFuncDelegate);

            //Console.WriteLine(string.Join(", ", namesLessThan4));// Ali, Amr, Ahd

            #endregion

            #region Find Strings More Than 4 Chars - List<string> namesMoreThan4 = FilterLists.FindElements<string>(names, FiltersOfList.StringMoreThanFour);

            //List<string> names = new List<string>()
            //{
            //    new string("Eslam"),
            //    new string("Ali"),
            //    new string("Amr"),
            //    new string("Ahd"),
            //    new string("Samir"),
            //    new string("Eman"),
            //};

            //List<string> namesMoreThan4 = FilterLists.FindElements<string>(names, FiltersOfList.StringMoreThanFour);

            //Console.WriteLine(string.Join(", ", namesMoreThan4));// Eslam, Samir

            #endregion

            #endregion

            #endregion

            #region Part 06 Builtin Delegate [Func, Action, Predicate]

            #region Predicate<T>

            //Predicate<int> predicate = new Predicate<int>(TestBuiltInDelegates.CheckPositive);
            //Console.WriteLine(predicate.Invoke(5));// True
            //Console.WriteLine(predicate.Invoke(-1));// False 

            ////Or use Func<int,bool>

            //Func<int,bool> predicate02 = new Func<int,bool>(TestBuiltInDelegates.CheckPositive);
            //Console.WriteLine(predicate02.Invoke(5));// True
            //Console.WriteLine(predicate02.Invoke(-1));// False 

            #endregion

            #region Func<T>

            //Func<int, string> func = new Func<int, string>(TestBuiltInDelegates.CastInt);
            //Console.WriteLine(func.Invoke(5));//5 [As string]
            //Console.WriteLine(func.Invoke(150));//150 [As string]

            #endregion

            #region Action - Non-Generic [Not return And Not take any parameters]

            //Action action = new Action(TestBuiltInDelegates.Print);
            //action.Invoke();//Hello World! 

            #endregion

            #region Action<T>

            //Action<string> action1 = new Action<string>(TestBuiltInDelegates.Print);
            //action1.Invoke("Eslam");//Hello Eslam!
            //action1.Invoke("Omar");//Hello Omar!

            #endregion

            #region Part 02 Delegate Example 01 - With Built In Delegate

            ////Step 01 - Declare Reference from delegate "StringFuncDelegate".

            //Func<string,int>? stringFunc;// Contain Garbage value now.

            ////Step 02 - Initialize this reference with object of type "StringFuncDelegate" 
            ////which has constructor that take any function "target function" that return "int" and take one parameter of type "string".

            ////stringFunc = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChar);
            //stringFunc = StringFunctions.GetCountOfUpperCaseChar;//Syntax Sugar for previous line.
            ////Now, The Reference "stringFunc" in STACk, Hold Address of the object of type "StringFuncDelegate" which
            ////Contain the function "GetCountOfUpperCaseChar" that take "string" parameter and return "int" value. 

            ////stringFunc = new StringFuncDelegate(StringFunctions.GetCountOfLowerCaseChar);//Make the reference "stringFunc" refer to a new object in heap that contain new method "GetCountOfLowerCaseChar".
            //stringFunc = new Func<string, int>(StringFunctions.GetCountOfUpperCaseChar) + new Func<string,int>(StringFunctions.GetCountOfLowerCaseChar);
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

            #region Part 03 Delegate Example 02 - With Built In Delegate

            #region Before using Delegate as a parameter - BubbleSort(int[] arr)

            //int[] numbers = new int[] { 7, 5, 6, 9, 8, 7, 5, 2, 3, 1 };
            //SortingAlgorithms.BubbleSort(numbers);

            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} ");// 1 2 3 5 5 6 7 7 8 9
            //} 
            ///Invalid Approach
            ///SortingAlgorithms.BubbleSortDesc(numbers);
            ///
            ///foreach (var item in numbers)
            ///{
            ///    Console.Write($"{item} ");// 9 8 7 7 6 5 5 3 2 1
            ///}

            #endregion

            #region Using delegate as a parameter that could refer to any function that take 2 int parameters and return bool - BubbleSort(int[] arr,SortingTypesFuncDelegate sortingType)

            #region Sort Asc - BubbleSort(numbers, func)

            //int[] numbersAsc = new int[] { 7, 5, 6, 9, 8, 7, 5, 2, 3, 1 };
            //Func<int, int, bool> func = SortingTypes.SortAsc;
            //SortingAlgorithms<int>.BubbleSortv02(numbersAsc, func);

            //foreach (var item in numbersAsc)
            //{
            //    Console.Write($"{item} ");// 1 2 3 5 5 6 7 7 8 9

            //}
            //Console.WriteLine();

            #endregion

            #region Sort Desc - BubbleSort(numbers, sortDescFunc)

            //int[] numbersDesc = new int[] { 7, 5, 6, 9, 8, 7, 5, 2, 3, 1 };
            //Func<int, int, bool> sortDescFunc = new Func<int, int, bool>(SortingTypes.SortDesc);
            //SortingAlgorithms<int>.BubbleSortv02(numbersDesc, sortDescFunc);

            //foreach (var item in numbersDesc)
            //{
            //    Console.Write($"{item} ");// 9 8 7 7 6 5 5 3 2 1

            //}

            #endregion

            #endregion


            #endregion

            #region Part 04 Delegate Example 02 With Generics

            //string[] names = new string[]
            //{
            //    new string("Ahmed"),
            //    new string("Eslam"),
            //    new string("Khaled"),
            //    new string("Amir"),
            //    new string("Sama"),
            //    new string("Nono"),
            //    new string("Ali"),
            //    new string("Amr")
            //};

            #region Sort Asc Based On string Length[Pass Function Direct] - BubbleSort(names, func)

            //Func<string, string, bool> func = SortingTypes.SortAsc;
            //SortingAlgorithms<string>.BubbleSortv02(names, func);
            //Console.WriteLine(string.Join(", ", names));//Ali, Amr, Amir, Sama, Nono, Ahmed, Eslam, Khaled

            #endregion

            #region Sort Desc Based on string Length [Pass Reference From Delegate That refer to function] - BubbleSort(names, sortingType).

            //Func<string, string, bool> sortingTypeFunc = new Func<string, string, bool>(SortingTypes.SortDesc);

            //SortingAlgorithms<string>.BubbleSortv02(names, sortingTypeFunc);
            //Console.WriteLine(string.Join(", ", names));//Khaled, Ahmed, Eslam, Amir, Sama, Nono, Ali, Amr

            #endregion

            #endregion

            #region Part 05 Delegate Example 03

            #region Before using Delegate as a parameter - List<int> oddNumbers = FilterLists.FindOddNumbers(numbers);

            //List<int> numbers = Enumerable.Range(1, 100).ToList();
            //List<int> oddNumbers = FilterLists.FindOddNumbers(numbers);
            //Console.WriteLine(string.Join(", ", oddNumbers));

            //Console.WriteLine(); 

            #region Invalid Approach.

            //List<int> EvenNumbers = FilterLists.FindEvenNumbers(numbers);
            //Console.WriteLine(string.Join(", ", EvenNumbers)); 

            #endregion

            #endregion

            #region Using delegate as a parameter that could refer to any function that take 1 int parameters and return bool - FindElement(List<int>[] numbers,FilterFuncDelegate FilterFunc)

            #region Find OddNumbers [Pass Function Direct] - List<int> oddNumbers = FilterLists.FindElements<int>(numbers, predicate);

            //List<int> numbers = Enumerable.Range(1, 100).ToList();
            //Predicate<int> predicate = FiltersOfList.CheckOdd;
            //List<int> oddNumbers = FilterLists.FindElementsv02<int>(numbers, predicate);

            //Console.WriteLine(string.Join(", ", oddNumbers));

            #endregion

            #region Find EvenNumbers[Pass Reference From Delegate That refer to function] - List<int> EvenNumbers = FilterLists.FindElements<int>(numbers, predicate);

            //List<int> numbers = Enumerable.Range(1, 100).ToList();
            //Predicate<int> predicate = new Predicate<int>(FiltersOfList.CheckEven);
            //List<int> EvenNumbers = FilterLists.FindElementsv02<int>(numbers, predicate);

            //Console.WriteLine(string.Join(", ", EvenNumbers));

            #endregion

            #region Find DivisibleBy7 elements - List<int> DivisiblesBy7 = FilterLists.FindElements<int>(numbers, predicate);

            //List<int> numbers = Enumerable.Range(1, 100).ToList();
            //Predicate<int> predicate= new Predicate<int>(FiltersOfList.DivisibleBy7);
            //List<int> DivisiblesBy7 = FilterLists.FindElementsv02<int>(numbers, predicate);

            //Console.WriteLine(string.Join(", ", DivisiblesBy7));//  7, 14, 21, 28, 35, 42, 49, 56, 63, 70, 77, 84, 91, 98

            #endregion

            #region Find DivisibleByTen elements - List<int> DivisiblesByTen = FilterLists.FindElements<int>(numbers, FiltersOfList.DivisibleByTen);

            //List<int> numbers = Enumerable.Range(1, 100).ToList();
            //Predicate<int> predicate = FiltersOfList.DivisibleByTen;
            //List<int> DivisiblesByTen = FilterLists.FindElementsv02<int>(numbers, predicate);

            //Console.WriteLine(string.Join(", ", DivisiblesByTen));//  10, 20, 30, 40, 50, 60, 70, 80, 90, 100

            #endregion

            #region Find Strings More Than 3 Chars - List<string> namesMoreThan3 = FilterLists.FindElements<string>(names, predicate);

            //List<string> names = new List<string>()
            //{
            //    new string("Eslam"),
            //    new string("Ali"),
            //    new string("Amr"),
            //    new string("Ahd"),
            //    new string("Samir"),
            //    new string("Eman"),
            //};

            //Predicate<string> predicate = FiltersOfList.StringMoreThanThree;
            //List<string> namesMoreThan3 = FilterLists.FindElementsv02<string>(names, predicate);

            //Console.WriteLine(string.Join(", ", namesMoreThan3));// Eslam, Samir, Eman

            #endregion

            #region Find Strings Less Than 4 Chars - List<string> namesLessThan4 = FilterLists.FindElements<string>(names, predicate);

            //List<string> names = new List<string>()
            //{
            //    new string("Eslam"),
            //    new string("Ali"),
            //    new string("Amr"),
            //    new string("Ahd"),
            //    new string("Samir"),
            //    new string("Eman"),
            //};

            //Predicate<string> predicate = new Predicate<string>(FiltersOfList.StringLessThanFour);
            //List<string> namesLessThan4 = FilterLists.FindElementsv02<string>(names, predicate);

            //Console.WriteLine(string.Join(", ", namesLessThan4));// Ali, Amr, Ahd

            #endregion

            #region Find Strings More Than 4 Chars - List<string> namesMoreThan4 = FilterLists.FindElements<string>(names, predicate);

            //List<string> names = new List<string>()
            //{
            //    new string("Eslam"),
            //    new string("Ali"),
            //    new string("Amr"),
            //    new string("Ahd"),
            //    new string("Samir"),
            //    new string("Eman"),
            //};

            //Predicate<string> predicate = FiltersOfList.StringMoreThanFour;
            //List<string> namesMoreThan4 = FilterLists.FindElementsv02<string>(names, predicate);

            //Console.WriteLine(string.Join(", ", namesMoreThan4));// Eslam, Samir

            #endregion

            #endregion

            #endregion

            #endregion

            #region Part 07 Anonymous Method And Lambda Expression

            #region Anonymous Method - use it when you need to use method once in specific line in code

            #region Predicate<T>

            ////Predicate<int> predicate = new Predicate<int>(TestBuiltInDelegates.CheckPositive);

            ////Anonymous Function - Take (int), return (bool)
            //Predicate<int> predicate = new Predicate<int>(delegate (int num) { return num > 0; });
            //Console.WriteLine(predicate.Invoke(5));// True
            //Console.WriteLine(predicate.Invoke(-1));// False 

            ////Or use Func<int,bool>

            ////Func<int, bool> predicate02 = new Func<int, bool>(TestBuiltInDelegates.CheckPositive);

            ////Anonymous Function
            //Func<int, bool> predicate02 = new Func<int, bool>(delegate (int num) { return num > 0; });
            //Console.WriteLine(predicate02.Invoke(5));// True
            //Console.WriteLine(predicate02.Invoke(-1));// False 

            #endregion

            #region Func<T>

            ////Func<int, string> func = new Func<int, string>(TestBuiltInDelegates.CastInt);

            ////Anonymous Function
            //Func<int, string> func = new Func<int, string>(delegate (int num) { return num.ToString(); });
            //Console.WriteLine(func.Invoke(5));//5 [As string]
            //Console.WriteLine(func.Invoke(150));//150 [As string]

            #endregion

            #region Action - Non-Generic [Not return And Not take any parameters]

            ////Action action = new Action(TestBuiltInDelegates.Print);

            ////Anonymous Method [Function Without Name & return & Access Modifier - inline functions for one usage]
            //Action action = new Action(delegate () { Console.WriteLine("Hello World!"); });

            //action.Invoke();//Hello World! 

            #endregion

            #region Action<T>

            ////Action<string> action1 = new Action<string>(TestBuiltInDelegates.Print);

            ////Anonymous Function [Define The Function inline - not need to define it in seperate class because i will use it once.]
            //Action<string> action1 = delegate (string name) { Console.WriteLine($"Hello {name}"); };
            //action1.Invoke("Eslam");//Hello Eslam!
            //action1.Invoke("Omar");//Hello Omar!

            #endregion 

            #endregion

            #region Lambda Expression - Enhancement for Anonymous method syntax.

            #region Predicate<T>

            ////Anonymous Function - Take (int), return (bool)
            ////Predicate<int> predicate = new Predicate<int>(delegate (int num) { return num > 0; });

            ////Lambda Expression
            //Predicate<int> predicate = new Predicate<int>(num => num > 0);
            //Console.WriteLine(predicate.Invoke(5));// True
            //Console.WriteLine(predicate.Invoke(-1));// False 

            ////Or use Func<int, bool>

            ////Func<int, bool> predicate02 = new Func<int, bool>(TestBuiltInDelegates.CheckPositive);

            ////Anonymous Function
            ////Func<int, bool> predicate02 = new Func<int, bool>(delegate (int num) { return num > 0; });

            ////Lambda Expression
            //Func<int, bool> predicate02 = new Func<int, bool>((num) => num > 0);
            //Console.WriteLine(predicate02.Invoke(5));// True
            //Console.WriteLine(predicate02.Invoke(-1));// False 

            #endregion

            #region Func<T>

            ////Func<int, string> func = new Func<int, string>(TestBuiltInDelegates.CastInt);

            ////Anonymous Function
            ////Func<int, string> func = new Func<int, string>(delegate (int num) { return num.ToString(); });

            ////Lambda Expression
            //Func<int, string> func = new Func<int, string>(num => num.ToString());
            //Console.WriteLine(func.Invoke(5));//5 [As string]
            //Console.WriteLine(func.Invoke(150));//150 [As string]

            #endregion

            #region Action - Non-Generic [Not return And Not take any parameters]

            ////Action action = new Action(TestBuiltInDelegates.Print);

            ////Anonymous Method [Function Without Name & return & Access Modifier - inline functions for one usage]
            ////Action action = new Action(delegate () { Console.WriteLine("Hello World!"); });

            ////Lambda Expression [Enhancement for Anonymous method syntax]
            //Action action = new Action(() => Console.WriteLine("Hello World!"));

            //action.Invoke();//Hello World! 

            #endregion

            #region Action<T>

            ////Action<string> action1 = new Action<string>(TestBuiltInDelegates.Print);

            ////Anonymous Function [Define The Function inline - not need to define it in seperate class because i will use it once.]
            ////Action<string> action1 = delegate (string name) { Console.WriteLine($"Hello {name}"); };

            ////Lambda Expression
            //Action<string> action1 = name => Console.WriteLine($"Hello {name}");
            //action1.Invoke("Eslam");//Hello Eslam!
            //action1.Invoke("Omar");//Hello Omar!

            #endregion 

            #endregion


            #endregion

        }
    }
}
