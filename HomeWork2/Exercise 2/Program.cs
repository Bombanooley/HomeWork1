using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Семиков Сергей

//Написать метод подсчета количества цифр числа.
namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int i=0, a = Convert.ToInt32(Console.ReadLine());
            bool Exit = false;
           while (Exit == false)
            {
                i++;
                a /= 10;
                if (a == 0) Exit = true;
            }
            
            if (i % 10 == 1) Console.Write($"В числе {i} цифра");
            else if (i % 10 == 2 || i % 10 == 3 || i % 10 == 4) Console.Write($"В числе {i} цифры");
            else Console.Write($"В числе {i} цифр");

            Console.ReadKey();
        }
    }
}
