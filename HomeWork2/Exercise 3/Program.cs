using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Семиков Сергей

//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.


namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1, sum=0;
            while ( a != 0)
            {
                Console.Write("Введите число: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 1 && a > 0) sum += a;
            }
            Console.WriteLine($"Сумма всех нечетных положительных чисел составляет: {sum}");
            Console.ReadKey();
        }
    }
}
