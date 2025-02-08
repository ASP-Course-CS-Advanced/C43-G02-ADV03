using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class MyList<T>: IEnumerable<T>
    {
        
        private T[] items;
        private int size;

        public MyList()
        {
            items = new T[4];
            size = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #region Methods

        #region Add()

        public void Add(T item)
        {
            if (size == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[size++] = item;
        }

        #endregion

        #region Exists()

        public bool Exists(Predicate<T> match)
        {
            for (int i = 0; i < size; i++)
            {
                if (match(items[i]))
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Find()
        public T Find(Predicate<T> match)
        {
            for (int i = 0; i < size; i++)
            {
                if (match(items[i]))
                {
                    return items[i];
                }
            }
            return default(T);
        }
        #endregion

        #region FindAll()

        public MyList<T> FindAll(Predicate<T> match)
        {
            MyList<T> result = new MyList<T>();
            for (int i = 0; i < size; i++)
            {
                if (match(items[i]))
                {
                    result.Add(items[i]);
                }
            }
            return result;
        }

        #endregion

        #region FindIndex()

        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < size; i++)
            {
                if (match(items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        #endregion

        #region FindLast()

        public T FindLast(Predicate<T> match)
        {
            for (int i = size - 1; i >= 0; i--)
            {
                if (match(items[i]))
                {
                    return items[i];
                }
            }
            return default(T);
        }

        #endregion

        #region FindLastIndex()

        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = size - 1; i >= 0; i--)
            {
                if (match(items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        #endregion

        #region ForEach()

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < size; i++)
            {
                action(items[i]);
            }
        }

      

        #endregion

        #region TrueForAll()

        public bool TrueForAll(Predicate<T> match)
        {
            for (int i = 0; i < size; i++)
            {
                if (!match(items[i]))
                {
                    return false;
                }
            }
            return true;
        }

     

        #endregion

        #endregion

    }
}
