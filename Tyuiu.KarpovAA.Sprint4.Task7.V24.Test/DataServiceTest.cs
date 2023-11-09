using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint4.Task7.V24.Lib;

namespace Tyuiu.KarpovAA.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int expected = 1179648;

           
            int result = ds.Calculate(5, 3, "651827384219648");

           
            Assert.AreEqual(expected, result);
        }
    }
}
