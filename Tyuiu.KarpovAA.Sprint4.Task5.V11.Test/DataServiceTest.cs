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
            
                // Arrange
                int[,] matrix = new int[,]
                {
                    { 1, -5, 3, 0, -2  },
                    { -4, 2, -1, 7, -3 },
                    { -6, -7, 0, 2, 1  },
                    { 4, -2, 5, -1, 0  },
                    { -3, 1, -4, 2, -7 }
                };

                int[,] expected = new int[,]
            {
              { 1, -5, 1, 0, -2  },
              { -4, 1, -1, 1, -3 },
              { -6, -7, 0, 1, 1  },
              { 1, -2, 1, -1, 0  },
              { -3, 1, -4, 1, -7 }
            };

                
                int[,] result = ds.Calculate(matrix);

                
                Assert.AreEqual(expected, result);
            }
        }
    }
