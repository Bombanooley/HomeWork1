using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Семиков Сергей

//Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
//Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

namespace Exercise_1
{
    delegate double function(double h,double j);

    class Program
    {
        static double f(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }

        static double g(double x, double a) 
        {
            return a * Math.Sin(x);
        }

        static void Plot(List<function> func, int start, int end)
        {
            double a = 1;
            for (int i = 0; i < func.Count; i++)
            {
                for (int x = start; x <= end; x++)
                {
                    Console.WriteLine($"f({x,4}) = {func[i](x,a),5}");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            List<function> methods = new List<function>() { f };
            methods.Add(g);
            Plot(methods, -5, 5);

            Console.ReadKey();
        }

    }
}
