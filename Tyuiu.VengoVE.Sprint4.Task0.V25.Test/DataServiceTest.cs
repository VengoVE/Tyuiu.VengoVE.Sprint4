using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VengoVE.Sprint4.Task0.V25.Lib;

namespace Tyuiu.VengoVE.Sprint4.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int sum = 0;
            int[] numsWaitArray = { 4, 2, 6, 4, 8, 6, 8, 4 };
            CollectionAssert.AreEqual(numsArray, numsWaitArray);
        }
    }
}
