﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VengoVE.Sprint4.Task4.V9.Lib;

namespace Tyuiu.VengoVE.Sprint4.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {

            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {  { 3, 7, 3, 1, 5 },
                                           { 6, 3, 2, 1, 2 },
                                           { 1, 3, 2, 8, 1 },
                                           { 5, 8, 1, 5, 1 },
                                           { 3, 3, 4, 4, 6 } };

            int res = ds.Calculate(mas2);
            int wait = 38;

            Assert.AreEqual(wait, res);
        }
    }
}
