using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a, b;
            Input(out a, out b);
            int c = CheckA();
            int d = CheckB();
            Fract z1 = new Fract(a, b);
            Fract z2 = new Fract(c, d);
            Output(z1);
            Output(z2);
            Sum(z1, z2);
            Sub(z1, z2);
            Mult(z1, z2);
            Div(z1, z2);
            Console.ReadKey();

        }

        private static void Input(out int a, out int b)
        {
            a = CheckA();
            b = CheckB();
        }       //Ввод дроби
        private static void Output(Fract z)
        {
            Console.WriteLine($"Дробь:\n\n{z}\n");
        }                   //Вывод дроби

        private static void Div(Fract z1, Fract z2)
        {
            Console.WriteLine($"Частное:\n\n{z1 / z2}\n");
        }           //Деление
        private static void Mult(Fract z1, Fract z2)
        {
            Console.WriteLine($"Произведение:\n\n{z1 * z2}\n");
        }          //Умножение

        private static void Sub(Fract z1, Fract z2)
        {
            Console.WriteLine($"Разность:\n\n{z1 - z2}\n");
        }           //Вычитание

        private static void Sum(Fract z1, Fract z2)
        {
            Console.WriteLine($"Сумма:\n\n{z1 + z2}\n");
        }           //Сложение

        static int CheckA()
        {
            bool cyc = true;
            int res = 0;
            do
            {
                Console.WriteLine($"Введите числитель ");
                string s = Console.ReadLine();
                bool flag = Int32.TryParse(s, out int a);
                if (!flag) Console.WriteLine("Неверный ввод");
                else
                {
                    cyc = false;
                    res = a;
                }
            }
            while (cyc);
            return res;
        }                          //Проверка ввода числителя
        static int CheckB()
        {
             bool cyc = true;
             int res = 0;
             do
             {
                    Console.WriteLine($"Введите знаменатель ");
                    string s = Console.ReadLine();
                    bool flag = Int32.TryParse(s, out int b);
                    if (!flag) Console.WriteLine("Неверный ввод");
                    else
                    {
                        try
                        {
                            if(b == 0) throw new ArgumentException(String.Format("Знаменатель не может быть равен 0"));
                            cyc = false;
                            res = b;
                    }
                        catch (ArgumentException error)
                        {
                            Console.WriteLine($"{error.Message}");
                        }
                        
                    }
             }
             while (cyc);
             return res;
        }                          //Проверка ввода знаменателя
    }
}
