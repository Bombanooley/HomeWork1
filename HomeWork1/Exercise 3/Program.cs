using System;
//Семиков Сергей

//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
//по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
//Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
namespace Exercise_3
{
    class Program
    {
        static double r1 (double x1, double y1, double x2, double y2)                                            //б)
        {
          double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;

        }
        static void Main(string[] args)
        {  
            Console.WriteLine("Введите X координату первой точки");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y координату первой точки");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите X координату второй точки");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y координату второй точки");
            double y2 = double.Parse(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));                                  //а)
            Console.WriteLine($"Расстояние между точками ({x1},{y1}) и ({x2},{y2}) равно {r}");                 

            Console.WriteLine($"Расстояние между точками ({x1},{y1}) и ({x2},{y2}) равно {r1(x1,y1,x2,y2)}");   //б)
            Console.ReadKey ();
        }
    }
}

