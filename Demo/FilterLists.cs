using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool FilterFuncDelegate<T>(T element);

    internal static class FilterLists
    {

        public static List<T> FindElements<T>(List<T> elements, FilterFuncDelegate<T> filterFunc)
        {
            List<T> result = new List<T>();

            if (elements?.Count > 0 && filterFunc is not null)
                for (int i = 0; i < elements.Count; i++)
                    //if (numbers[i] % 2 == 1)
                    if (filterFunc.Invoke(elements[i]))//Delegate this line to let the user pass it as parameter to this function by make function that check if number even,
                        result.Add(elements[i]);       //and let reference from delegate with signature same with function refer to it.


            return result;
        }
        
        public static List<T> FindElementsv02<T>(List<T> elements, Predicate<T> filterFunc)
        {
            List<T> result = new List<T>();

            if (elements?.Count > 0 && filterFunc is not null)
                for (int i = 0; i < elements.Count; i++)
                    //if (numbers[i] % 2 == 1)
                    if (filterFunc.Invoke(elements[i]))//Delegate this line to let the user pass it as parameter to this function by make function that check if number even,
                        result.Add(elements[i]);       //and let reference from delegate with signature same with function refer to it.


            return result;
        }

        //Invalid Approach [there are 2 functions with same body, the difference is just condition - so let the user enter this condition]
        // as a parameter , this parameter will be reference from delegate refer to function that take parameter "int" and return bool.
        // and then make functions as you need that check if number odd or check even or check any thing and let the delegate reference refer to it
        // and then add this number to the new list if it pass the condition.

        ///public static List<int> FindEvenNumbers(List<int> numbers)
        ///{
        ///    List<int> result = new List<int>();
        ///
        ///    if (numbers?.Count > 0)
        ///        for (int i = 0; i < numbers.Count; i++)
        ///            if (numbers[i] % 2 == 0)
        ///                result.Add(numbers[i]);
        ///
        ///    return result;
        ///}

    }
}
