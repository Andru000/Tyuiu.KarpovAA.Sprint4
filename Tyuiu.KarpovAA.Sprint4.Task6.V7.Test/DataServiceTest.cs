using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint4.Task6.V7.Lib;

namespace Tyuiu.KarpovAA.Sprint4.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] array = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Экономика" };


            
            int count = ds.Calculate(array);

      
            Assert.AreEqual(3, count);


        }
    }
}
