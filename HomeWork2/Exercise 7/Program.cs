using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Семиков Сергей  

//a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число ");
            long A = Convert.ToInt64 (Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            long B = Convert.ToInt64(Console.ReadLine());
            AdoB(A, B);
            Console.WriteLine(Sum(A, B));
            Console.ReadKey();
        }
        static void AdoB(long a, long b)
        {
            if (a <= b)                 //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
            {                 
                Console.WriteLine(a);
                a++;
                AdoB(a, b);
            }
        }
        static long Sum(long a,long b)  //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        {
            if (a <= b) 
                return Sum(a + 1, b) + a;
            else 
                return 0;
            
        }
           
        
    }
}
