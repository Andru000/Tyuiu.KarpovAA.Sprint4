using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KarpovAA.Sprint4.Task6.V7.Lib
{
    public class DataService : ISprint4Task6V7
    {
        public int Calculate(string[] array)
        {
            int count = 0;

            foreach (string item in array)
            {
                if (item.Length > 8)
                {
                    count++;
                }
            }

            return count;
        
        }
    }
}
