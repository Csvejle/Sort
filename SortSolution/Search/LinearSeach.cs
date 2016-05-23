using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class LinearSeach : ISearch
    {
        public int Count<T>(T[] array, T value) where T : IComparable, IComparable<T>
        {
            int count = 0;

            if (array != null)
            {
                if (array.Length > 0)
                {
                    for(int current = 0; current < array.Length; current++)
                    {
                        if (array[current].CompareTo(value) == 0) { count++; }
                    }
                }
            }

            return count;
        }

        public bool Contains<T>(T[] array, T value) where T : IComparable, IComparable<T>
        {
            bool found = false;
            int index = 0;

            if (array != null && value != null)
            {
                if (array.Length > 0)
                {
                    while (!found && index < array.Length)
                    {
                        if (array[index].CompareTo(value) == 0) { found = true; }
                        else { index++; }
                    }
                }
            }

            return found;
        }
    }
}
