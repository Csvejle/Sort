using Microsoft.VisualStudio.TestTools.UnitTesting;
using Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Tests
{
    [TestClass()]
    public class LinearSeachTests
    {
        LinearSeach TestInstance { get; set; }

        readonly int[] arrayToSearch = new int[] { 5, 1, 3, 9, 5, 0, 7, 8, 9, 7, 11 };

        [TestInitialize]
        public void Prepare()
        {
            TestInstance = new LinearSeach();
        }

        [TestMethod()]
        public void Count()
        {
            int toFind = 14;
            int found = TestInstance.Count(arrayToSearch, toFind);
            Assert.IsTrue(found == 0);

            toFind = 5;
            found = TestInstance.Count(arrayToSearch, toFind);
            Assert.IsTrue(found == 2);
          
            toFind = 11;
            found = TestInstance.Count(arrayToSearch, toFind);
            Assert.IsTrue(found == 1);

        }

        [TestMethod()]
        public void Contains()
        {
            int toFind = 14;
            Assert.IsFalse(TestInstance.Contains(arrayToSearch, toFind));

            toFind = 5;
            Assert.IsTrue(TestInstance.Contains(arrayToSearch, toFind));
        }
    }
}