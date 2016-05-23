using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchLibTest
{
    [TestClass]
    public class UnitTest
    {
         TestInstance { get; set; }

        readonly int[] UnsortedArray = new int[] { 5, 1, 3, 9, 5, 0, 7, 8, 9, 7, 11 };
        readonly int[] ArrayTest = new int[] { 0, 1, 3, 5, 5, 7, 7, 8, 9, 9, 11 };

        [TestInitialize]
        public void Prepare()
        {
        }
    }
}
