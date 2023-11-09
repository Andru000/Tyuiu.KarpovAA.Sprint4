using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint4.Task5.V11.Lib;

namespace Tyuiu.KarpovAA.Sprint4.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

         
            int[,] mtrx = new int[2, 2] { {-5, 2 },
                                          { 2, 1} };
            int[,] res = new int[2, 2] { {-5, 1 },
                                         { 1, 1} };

            CollectionAssert.AreEqual(ds.Calculate(mtrx), res);
        }
    }
}
