using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VengoVE.Sprint4.Task2.V22.Lib;

namespace Tyuiu.VengoVE.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 0, 3, 12, 11 };

            int res = ds.Calculate(numsArray);
            int wait = 23;

            Assert.AreEqual(wait, res);
        }
    }
}
