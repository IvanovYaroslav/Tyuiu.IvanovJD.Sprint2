using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint2.Task3.V16.Lib;

namespace Tyuiu.IvanovJD.Sprint2.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 36;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckCalculate3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 128;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckCalculate4()
        {
            DataService ds = new DataService();
            double x = -100;
            double res = ds.Calculate(x);
            double wait = -1099.99;
            Assert.AreEqual(wait, res);
        }
    }
}
