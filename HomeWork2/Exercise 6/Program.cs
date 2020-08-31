using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Семиков Сергей  

//*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
//«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт
//времени выполнения программы, используя структуру DateTime.

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int sum = 0, sumC = 0;
          for (long i = 1; i<=100000; i++)             //При 1 миллиарде чисел 61574510 "хороших"
                if (i % Sum(i) == 0) sum++;            //Программа выполнена за 00:04:49.1558985

            Console.WriteLine(sum);
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Программа выполнена за {finish-start}");
            Console.ReadKey();
        }
        static long Sum(long a)
        {
            if (a == 0) return 0;
            else return Sum(a / 10) + a % 10;
        }

    }
}
