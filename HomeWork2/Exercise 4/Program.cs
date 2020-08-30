using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Семиков Сергей  

//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
//программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

namespace Exercise_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Count = 3;
            do
            {
                Console.Write("Введите логин ");
                string Log = Console.ReadLine();
                Console.Write("Введите пароль ");
                string Pas = Console.ReadLine();
                Count--;
                if (Check(Log, Pas, Count) == true)
                {
                    Console.WriteLine("Доступ получен!");
                    Count = 0;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"В доступе отказано!\nПопыток осталось: {Count}");
                }
            }
            while (Count != 0);
            Console.ReadKey();
        }
        static bool Check(string log, string pas, int count)
        {
            if (log == "root" && pas == "GeekBrains") return true;
            else return false;

        }

    }
}
