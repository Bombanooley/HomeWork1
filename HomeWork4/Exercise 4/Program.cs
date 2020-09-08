using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Семиков Сергей

//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
//программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

//Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
//Создайте структуру Account, содержащую Login и Password.

namespace Exercise_4
{
    struct Account
    {
        string[] Log, Pas;

        public Account(string[,] input, int length)
        {
            Log = new string[length];
            Pas = new string[length];
            for (int i = 0; i < input.Length / 2; i++)
            {
                Log[i] = input[i, 0];
                Pas[i] = input[i, 1];
            }
        }
        public string Login(int i)
        {
            return Log[i];
        }
        public string Password(int i)
        {
            return Pas[i];
        }

        public void Password(string[,] input, int length)
        {
            for (int i = 0; i < length; i++) Console.WriteLine(input[i, 1]);
        }
    }
    class Program
        {
            static void Main(string[] args)
            {
                int leng = 0;
                string[,] UserData = ReadFromFile(ref leng);
                for (int i = 0; i < leng; i++)
                {
                    if (Check(UserData[i , 0], UserData[i , 1]) == true)
                        Console.WriteLine("Доступ получен!");
                    else Console.WriteLine("В доступе отказано!");
                }
            Account Data = new Account(UserData,leng);
                Console.WriteLine(Data.Login(1));
                Console.WriteLine(Data.Password(1));
                Console.WriteLine(Data.Login(5));
                Console.WriteLine(Data.Password(5));
            Console.ReadKey();
        }
            private static bool Check(string log, string pas)
            {
                if (log == "root" && pas == "GeekBrains") return true;
                else return false;
            }

        private static string[,] ReadFromFile(ref int length)
            {
                StreamReader reader = new StreamReader("Base.txt");
            length =Convert.ToInt32 (reader.ReadLine());
                string[,] temp = new String[length, 2];
            for (int i = 0; !reader.EndOfStream; i++)
                {
                    temp[i, 0] = reader.ReadLine();
                    temp[i, 1] = reader.ReadLine();
                }
                reader.Close();
                return temp;
            }
    }
}
