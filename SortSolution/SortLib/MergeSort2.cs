﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLib
{
    public class MergeSort2 : AMerge, ISort
    {

        public T[] Sort<T>(T[] array) where T : IComparable, IComparable<T>
        {
            T[] result;

            // If list size is 0 (empty) or 1, consider it sorted and return it
            // (using less than or equal prevents infinite recursion for a zero length array).
            if (array.Length <= 1)
            {
                result = array;
            }
            else
            {
                // Else list size is > 1, so split the list into two sublists.
                int middleIndex = (array.Length) / 2;
                T[] left = new T[middleIndex];
                T[] right = new T[array.Length - middleIndex];

                Array.Copy(array, left, middleIndex);
                Array.Copy(array, middleIndex, right, 0, right.Length);

                // Recursively call MergeSort() to further split each sublist
                // until sublist size is 1.
                left = Sort(left);
                right = Sort(right);

                // Merge the sublists returned from prior calls to MergeSort()
                // and return the resulting merged sublist.
                result = Merge2(left, right);
            }
            return result;
        }
    }
}
