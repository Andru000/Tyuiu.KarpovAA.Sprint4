﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint4.Task0.V1.Lib;

namespace Tyuiu.KarpovAA.Sprint4.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int[] Array = new int[] { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
            int wait = 20;
            int res = ds.GetSumEvenArrEl(Array);
            Assert.AreEqual(wait, res);

        }
    }
}
