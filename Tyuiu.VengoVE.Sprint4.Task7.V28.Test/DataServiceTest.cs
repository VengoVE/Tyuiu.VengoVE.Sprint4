using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VengoVE.Sprint4.Task7.V28.Lib;

namespace Tyuiu.VengoVE.Sprint4.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "623351179845632";
            int res = ds.Calculate(rows, columns, str);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
