using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VengoVE.Sprint4.Task6.V22.Lib;

namespace Tyuiu.VengoVE.Sprint4.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var weather = new string[] { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };
            int res = ds.Calculate(weather);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
