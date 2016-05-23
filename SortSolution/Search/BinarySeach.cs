using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class BinarySeach : ISearch
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
      
            if (array != null && value != null)
            {
                if (array.Length > 0)
                {
                    int left = 0;
                    int right = array.Length-1;
                    int middle = right/2;

                    while (!found && left < right)
                    {
                        if (array[middle].CompareTo(value) > 0)
                        {
                            right = middle - 1;
                        }
                        else if(array[middle].CompareTo(value) < 0)
                        {
                            left = middle + 1;
                        }
                        else
                        {
                            found = true;
                        }

                        middle = (right + left) / 2;
                    }
                }
            }

            return found;
        }
    }
}
