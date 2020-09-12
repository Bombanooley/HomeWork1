using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


//Семиков Сергей

//Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет 
//    строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом 
//    цифра не может быть первой:
//а) без использования регулярных выражений;
//б) **с использованием регулярных выражений.

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correct;
            string input = Input();
            correct = Check(input);
            Output(correct);
            Pause();
        }

        private static void Pause()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Ввод логина
        /// </summary>
        /// <returns></returns>
        private static string Input()
        {
            Console.Write("Введите логин ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Проверка логина
        /// </summary>
        /// <param name="input">Логин(строка)</param>
        /// <returns></returns>
        private static bool Check(string input)
        {
            if (input[0] >= '1' && input[0] <= '9') return false;
            if (input.Length < 3 || input.Length > 10) return false;
            for (int i = 0; i < input.Length; i++)
            {
                bool checkDigit = char.IsDigit(input[i]);
                bool checkLetter = false;
                if ((input[i] >= 'a' && input[i] <= 'z') || 
                    (input[i] >= 'A' && input[i] <= 'Z')) 
                        checkLetter = true;
                if (checkDigit == false && checkLetter == false) return false;
            }
            return true;
        }

        /// <summary>
        /// Вывод результата проверки
        /// </summary>
        /// <param name="correct">bool результат проверки</param>
        private static void Output(bool correct)
        {
            if (correct) Console.WriteLine("Логин корректный");
            else Console.WriteLine("Логин не корректный");
        }

    }
}
