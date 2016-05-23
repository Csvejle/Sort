using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public interface ISearch
    {
        /**
            summary: can Search an array.
        */
        // T Find<T>(T[] array, T value) where T : IComparable, IComparable<T>;


        /**
         *  Summary:
         *  Returnerer, hvor mange gange en given værdi optræder, i den angivne liste.
         *  Typen der udgøre T, skal være comparable, og listen skal indeholde minimum et element. 
         */
        int Count<T>(T[] array, T value) where T : IComparable, IComparable<T>;


        /** 
         * Summary: 
         * Returnerer om en givnen værdi findes, i den angivne liste. 
         * Typen der udgøre T, skal være comparable, og listen skal indeholde minimum et element.
        */
        bool Contains<T>(T[] array, T value) where T : IComparable, IComparable<T>;
     }
}
