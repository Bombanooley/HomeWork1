using System;
//Семиков Сергей

////Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.
namespace Exercise_4
{
    class Program
    {
            static void Three (double a, double b)             //а) с использованием третьей переменной;
            {
                double c = a;
                 a = b;
                 b = c;
                 Console.WriteLine($"a = {a}, b = {b}");

            }
            static void Two(double a, double b)                //б) *без использования третьей переменной.
            {
                 a = a + b;
                 b = a - b;
                 a = a - b;
                Console.WriteLine($"a = {a}, b = {b}");
            }

            static void Main(string[] args)
            {   
                 Console.WriteLine("Введите первую переменную (a)");
                 double a = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вторую переменную (b)");
                 double b = Convert.ToDouble (Console.ReadLine());

                 Three(a, b);                                            //а)
                 Two(a, b);                                              //б)
    
                 Console.ReadKey();
            }
    }
}
