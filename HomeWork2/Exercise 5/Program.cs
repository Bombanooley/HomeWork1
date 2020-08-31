using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Семиков Сергей  

//а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс 
//массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой вес в килограммах");
            string m = Console.ReadLine();
            Console.WriteLine("Введите свой рост в метрах");
            string h = Console.ReadLine();
            const double indMin = 18.5, indMax = 25;
            double ind = Convert.ToDouble(m) / Math.Pow(Convert.ToDouble(h), 2), m1=0, ind1=0;
            Console.WriteLine($"Ваш ИМТ составляет {ind}");
            if (ind < indMin)
            {
                for (double i = Convert.ToDouble(m); ind1 <= indMin; i += 0.5)
                {
                    ind1 = Convert.ToDouble(i) / (Math.Pow(Convert.ToDouble(h), 2));
                    m1 = i - Convert.ToDouble(m);
                }

                Console.WriteLine($"Необходимо набрать киллограмм: {m1}");
            }
            else if (ind > indMax)
            {
                ind1 = indMax;
                for (double i = Convert.ToDouble(m); ind1 >= indMax; i -= 0.5)
                {
                    ind1 = Convert.ToDouble(i) / (Math.Pow(Convert.ToDouble(h), 2));
                    m1 = Convert.ToDouble(m) - i;
                }
                Console.WriteLine($"Необходимо сбросить киллограмм: {m1}");

            }
            else Console.WriteLine("Ваш вес в норме");
            Console.ReadKey();
        }
    }
}
