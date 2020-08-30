using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.SmallBasic.Library;

//Семиков Сергей

//Написать метод, возвращающий минимальное из трёх чисел.

namespace HomeWork2
{
    class Program
    {

        static int Min ()
            {
            Console.Write("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a = {a}  b = {b}  c = {c} ");

            if (a < b && a < c) return a;
            else if (b < a && b < c) return b;
            else return c;
                        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Min());
            Console.ReadKey();
        }
    }
}
