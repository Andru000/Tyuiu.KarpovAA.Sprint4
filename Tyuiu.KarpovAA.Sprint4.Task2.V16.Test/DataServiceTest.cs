﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint4.Task2.V16.Lib;

namespace Tyuiu.KarpovAA.Sprint4.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            int[] numsArray = { 7, 6, 9, 8, 9, 7, 4, 7, 8, 5 };

            int res = ds.Calculate(numsArray);
            int wait = 44;

            Assert.AreEqual(wait, res);
               
        }
    }
}
