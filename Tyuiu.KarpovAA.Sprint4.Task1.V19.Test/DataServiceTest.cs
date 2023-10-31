﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint4.Task1.V19.Lib;

namespace Tyuiu.KarpovAA.Sprint4.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4 };

            Assert.AreEqual(32, ds.Calculate(numsArray));
        }
    }
}
