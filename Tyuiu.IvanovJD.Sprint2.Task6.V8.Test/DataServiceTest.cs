using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint2.Task6.V8.Lib;

namespace Tyuiu.IvanovJD.Sprint2.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int m = 10;
            int n = 31;
            string wait = (30 + "." + 10);
            string res = ds.FindDateOfPreviousDay(m, n);
            Assert.AreEqual(res, wait);
        }
    }
}