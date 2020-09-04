using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Семиков Сергей

//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rand = new Random();
            //Console.WriteLine(rand.Next(2));
     
            Complex z1 = new Complex(ReIn: 4, ImIn: 5);
            Complex z2 = new Complex(ReIn: 1, ImIn: 20);

            Console.WriteLine($"Первое число: {z1}");
            Console.WriteLine($"Второе число: {z2}");
            Console.WriteLine($"Сумма чисел: {z1 + z2}");
            Console.WriteLine($"Разность чисел: {z1 - z2}");
            Console.WriteLine($"Произведение чисел: {z1 * z2}");

            Console.ReadKey();
            

        }

    }
}
