using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint2.Task4.V16.Lib;

namespace Tyuiu.IvanovJD.Sprint2.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 1.25;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckCalculate2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 576;
            double res = ds.Calculate(x, y);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
