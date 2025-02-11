using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class MyList1<T>:IEnumerable<T>
    {
        private T[] arr;
        public int size;

        public MyList1()
        {
            arr = new T[4];
            size = 0;
        }

        public void Add(T element)
        {
            if (size == arr.Length)
                Array.Resize(ref arr, arr.Length * 2);
            arr[size] = element;
            size++;
        }

        public bool Exist(Predicate<T> predicate)
        {
            for (int i = 0; i < size; i++)
            {
                if (predicate.Invoke(arr[i]))
                    return true;
            }
            return false;
        }

        public T Find(Predicate<T> predicate)
        {
            for (int i = 0; i < size; i++)
            {
                if (predicate.Invoke(arr[i]))
                {
                    return arr[i];
                }
            }
            return default;
        }

        public MyList1<T> FindAll(Predicate<T> predicate)
        {
            MyList1<T> newList = new MyList1<T>();
            for (int i = 0; i < size; i++)
            {
                if (predicate.Invoke(arr[i]))
                    newList.Add(arr[i]);
            }
            return newList;
        }

        public int FindIndex(Predicate<T> predicate)
        {
            for (int i = 0; i < size; i++)
                if (predicate.Invoke(arr[i]))
                    return i;
            return -1;
        }

        public T FindLast(Predicate<T> predicate)
        {
            for (int i = size - 1; i > 0; i--)
            {
                if (predicate.Invoke(arr[i]))
                    return arr[i];
            }
            return default(T);
        }

        public int FindLastIndex(Predicate<T> predicate)
        {
            for (int i = size - 1; i > 0; i--)
                if (predicate.Invoke(arr[i]))
                    return i;
            return -1;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < size; i++)
            {
                action.Invoke(arr[i]);
            }
        }

        public bool TrueForAll(Predicate<T> predicate)
        {
            bool AllTrue = true;
            if (size == 0)
                return true;
            for (int i = 0; i < size; i++)
            {
                if (!predicate.Invoke(arr[i]))
                    AllTrue = false;
            }
            if (AllTrue)
                return true;
            else
                return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
