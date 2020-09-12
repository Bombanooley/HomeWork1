using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Семиков Сергей

//*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
//Например:
//badc являются перестановкой abcd.

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ChechShift();

            Console.ReadKey();
        }

        /// <summary>
        /// Является ли одна строка перестановкой другой
        /// </summary>
        private static void ChechShift()
        {
            string a = "фывапролд", b = "длорпавыф", temp = "";
            for (int i = a.Length - 1; i >= 0; i--)
                temp = temp + a[i];
            if (temp == b) Console.WriteLine($"Строка {a} является перестановкой строки {b}");
            else Console.WriteLine($"Строка {a} не является перестановкой строки {b}");
        }
    }
}
