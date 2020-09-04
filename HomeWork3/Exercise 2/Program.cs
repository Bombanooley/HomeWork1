using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Семиков Сергей

//// а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
//Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
////б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
//При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Total answ = Sum();
            Console.WriteLine($"Вы ввели следущие нечётные положительные числа: {answ.SOUT}");
            Console.WriteLine($"Сумма всех нечетных положительных чисел составляет: {answ.SUM}");
            Console.ReadKey();
        }

        static Total Sum()
        {
            string s, sOut = "";
            int a, sum = 0;
            bool flag;
            Total ans= new Total("",0);
            do
            {
                s = Input();
                flag = Int32.TryParse(s, out a);
                if (!flag)
                {
                    Console.WriteLine("Неверный ввод");
                    a = 1;
                    continue;
                }
                else if (a % 2 == 1 && a > 0)
                {
                    sum += a;
                    sOut += s + " ";
                }
            }
            while (a != 0);
            ans.SOUT = sOut;
            ans.SUM = sum;
            return ans;
        }

        static string Input()
        {
            Console.Write("Введите число: ");
            return Console.ReadLine();
        }
    }
}
