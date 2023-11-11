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

            int rows = 5, colums = 3;
            int[,] mtrx = new int[rows, colums];
            string str = "651827384219648";

            int res = ds.Calculate(rows, colums, str);

            Assert.AreEqual(1179648, res);
        }
    }
}
