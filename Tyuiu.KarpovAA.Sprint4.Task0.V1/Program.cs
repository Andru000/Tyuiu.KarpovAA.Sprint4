using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KarpovAA.Sprint4.Task0.V1.Lib;

namespace Tyuiu.KarpovAA.Sprint4.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Карпов А. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Карпов Андрей Андреевич | ИИПб-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива. {6 ,4 ,3 ,2 ,1 ,0 ,9 ,8 ,7 ,5}                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("{6 ,4 ,3 ,2 ,1 ,0 ,9 ,8 ,7 ,5}"); 

            int[] Array = new int[] { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetSumEvenArrEl(Array);
            Console.WriteLine(res);
             
            Console.ReadKey();

        }
    }
}
