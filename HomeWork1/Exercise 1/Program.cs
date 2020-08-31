using System;
//Семиков Сергей

//Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
//В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.
namespace Home_Work_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string sname = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string oname = Console.ReadLine();
            Console.WriteLine("Введите рост в метрах");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес в килограммах");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine(sname + " " + name + " " + oname + " " + l + "м " + w + "кг");     //а) используя склеивание;

            Console.WriteLine("{0} {1} {2} {3:F2}м {4:F1}кг", sname, name, oname, l, w);         //б) используя форматированный вывод;

            Console.WriteLine($"{sname} {name} {oname} {l}м {w}кг");                             //в) используя вывод со знаком $.

            Console.ReadKey ();
        }
    }
}
