using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Семиков Сергей

//На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
//В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, 
//каждая из следующих N строк имеет следующий формат:
//< Фамилия > < Имя > < оценки >,
//где < Фамилия > — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более 
//чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по 
//пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
//Пример входной строки:
//Иванов Петр 4 5 3
//Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии 
//и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики, набравшие 
//тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.


namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] list = ReadFromFile();
            Output(list, Lower(list));

            Console.ReadKey();
        }

        /// <summary>
       /// Считываем из файла
       /// </summary>
       /// <returns>Массив</returns>
        private static Student[] ReadFromFile()
        {
            int count = 0;
            Student[] list = new Student[100];
            StreamReader sr = new StreamReader("list.txt");
            for (int i = 0; !sr.EndOfStream; i++)
            {
                list[i] = new Student("list.txt", sr);
                count++;
            }
            Array.Resize(ref list, count);
            sr.Close();
            return list;
        }

        /// <summary>
        /// Ищем худших учеников
        /// </summary>
        /// <param name="list">Массив с перечнем студентов и их оценок</param>
        /// <returns>Отсортированный массив средних оценок</returns>
        private static double[] Lower(Student[] list)
        {
            double [] min = new double [list.Length];
            for (int i = 0; i < list.Length; i++)
                min[i] = list[i].Average;
            Array.Sort(min);
            int size = 3;
            for (int i = 3; i < min.Length; i++)
            {
                if (min[i] == min[0] || min[i] == min[1] || min[i] == min[2]) size++;
            }
            Array.Resize(ref min, size);
            return min;
        }

        /// <summary>
        /// Вывод на экран
        /// </summary>
        /// <param name="list">Массив с перечнем студентов и их оценок</param>
        /// <param name="min">Массив с индексами худших учеников</param>
        private static void Output(Student [] list, double[] min)
        {
            for (int i = 0; i < list.Length; i++)
                for (int j = 0; j < min.Length; j++)
                    if (list[i].Average == min[j])
                    {
                        Console.WriteLine($"{list[i].Surname} {list[i].Name}: Средний балл - {list[i].Average}");
                        break;
                    }
        }
    }
}
