using System;
using System.Threading.Tasks.Dataflow;
//Семиков Сергей

//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);
//где m — масса тела в килограммах, h — рост в метрах.
namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Введите свой вес в килограммах");
            string m = Console.ReadLine();
            Console.WriteLine("Введите свой рост в метрах");
            string l = Console.ReadLine();

            double i = Convert.ToDouble(m) / (Convert.ToDouble(l) * Convert.ToDouble(l));
            Console.WriteLine($"Ваш ИМТ составляет {i}");

            Console.ReadKey();
        }
    }
}
