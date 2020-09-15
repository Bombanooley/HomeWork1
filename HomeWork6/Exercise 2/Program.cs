using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Семиков Сергей

//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
//а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. 
//    Использовать массив (или список) делегатов, в котором хранятся различные функции.
//б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр 
//    (с использованием модификатора out). 

namespace Exercise_2
{
    delegate double function(double x);

    class Program
    {
        static void Main(string[] args)
        {
            List<function> functions = new List<function>();
            functions.Add(F);
            functions.Add(G);
            functions.Add(K);
            char func = FuncInput();
            double min;
            SaveFunc("data.bin", func, -10, 10, 0.5);
            double[] arr = Load("data.bin", out min);
            Console.WriteLine($"Минимальное значение: {min}");
            Load("data.bin");
            Console.ReadKey();
        }

        /// <summary>
        /// Функия F
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        /// <summary>
        /// Функия G
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double G(double x)
        {
            return Math.Pow(x,3);
        }

        /// <summary>
        /// Функия K
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double K(double x)
        {
            return Math.Cos(Math.PI * x);
        }

        /// <summary>
        /// Сохраняем значения функции в файл
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <param name="func">Выбор функции</param>
        /// <param name="a">Минимальное значение аргумента</param>
        /// <param name="b">Максимальное значение аргумента</param>
        /// <param name="h">Шаг значения аргумента</param>
        public static void SaveFunc(string fileName, char func, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                if (func == 'f')
                bw.Write(F(x));
                if (func == 'g')
                    bw.Write(G(x));
                if (func == 'k')
                    bw.Write(K(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Считываем значения из функции и ищем минимальное
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <param name="min">Переменная в котрую будет записано минимальное значение</param>
        /// <returns>Массив значений функции</returns>
        public static double[] Load(string fileName, out double min)
        {
            double minn = Double.MaxValue;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double d;
            double[] arr = new double[fs.Length / sizeof(double)];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                arr[i] = bw.ReadDouble();
                d = arr[i];
                //Console.WriteLine($"{d,10}");                     //Вывод значений функции
                if (d < minn) minn = d;
            }
            bw.Close();
            fs.Close();
            min = minn;
            return arr;
        }

        /// <summary>
        /// Считываем значения из функции и выводим
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <returns>Минимальное значение</returns>
        public static void Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double d;
            double[] arr = new double[fs.Length / sizeof(double)];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                arr[i] = bw.ReadDouble();
                Console.WriteLine($"{arr[i],10}");                     //Вывод значений функции
            }
            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Выбор функции
        /// </summary>
        /// <returns>Выбранная буква функции</returns>
        private static char FuncInput()
        {
            char func = 'a';
            bool res = false;
            Console.WriteLine("Выберите функцию: f, g или k\nf(x) = x^2 - 50x + 10\ng(x) = x ^ 3\nk(x) = Cos(PI*x)");
            while (!res)
            {
                func = Console.ReadKey(true).KeyChar;
                Console.WriteLine(func);
                if (!char.IsLetter(func)) Console.WriteLine("Неверный формат");
                else if (func != 'f' && func != 'g' && func != 'k') Console.WriteLine("Такая функция не существует");
                else res = true;
            }
            return func;
        }
    }

}
