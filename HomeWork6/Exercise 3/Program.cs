using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Семиков Сергей

//Переделать программу Пример использования коллекций для решения следующих задач:
//а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
//в) отсортировать список по возрасту студента;
//г) *отсортировать список по курсу и возрасту студента;

namespace Exercise_3
{
    class Program
    {
        static List<Student> Read(out int bakalavr, out int magistr)
        {
            int bakalavrR = 0;
            int magistrR = 0;
            List<Student> list = new List<Student>();
            StreamReader sr = new StreamReader("students_6.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    if (int.Parse(s[5]) < 5) bakalavrR++; else magistrR++;              //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        bakalavr = bakalavrR;
                        magistr = magistrR;
                        break;
                    }
                }
            }
            sr.Close();
            bakalavr = bakalavrR;
            magistr = magistrR;
            return list;
        }
        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            DateTime dt = DateTime.Now;
            List<Student> list = Read(out bakalavr, out magistr);                              
            
            Console.WriteLine($"Учащихся 5-6 курсов: {magistr}");             //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            Console.WriteLine();

            int[] freq = Freq(list);
            FreqOutput(freq);                                                 //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
            Console.WriteLine();

            SortAge(list);                                                    //в) отсортировать список по возрасту студента;
            Console.WriteLine();

            SortCourseAge(list);                                              //г) *отсортировать список по курсу и возрасту студента;
            Console.WriteLine();

            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }

        /// <summary>
        /// Вывод частотного массива
        /// </summary>
        /// <param name="freq">Частотный массив</param>
        private static void FreqOutput(int[] freq)
        {
            for (int i = 1; i < freq.Length; i++)
                Console.WriteLine($"На {i} курсе учится {freq[i]} студент(ов) от 18 до 20 лет");
        }

        /// <summary>
        /// Сортировка по возрасту
        /// </summary>
        /// <param name="list"></param>
        private static void SortAge(List<Student> list)
        {
            list.Sort(new Comparison<Student>(CompareAge));
            foreach (var v in list) Console.WriteLine($"{v.firstName,10} {v.age,5}");
        }

        /// <summary>
        /// Сортировка по курсу и возрасту
        /// </summary>
        /// <param name="list"></param>
        private static void SortCourseAge(List<Student> list)
        {
            list.Sort(new Comparison<Student>(CompareCourseAge));
            foreach (var v in list) Console.WriteLine($"Студент: {v.firstName,10} Курс: {v.course} Возраст: {v.age,3} "); //г) *отсортировать список по курсу и возрасту студента;
        }

        /// <summary>
        /// Сравнение по именам
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int CompareName(Student st1, Student st2)         
        {
            return String.Compare(st1.firstName, st2.firstName);          
        }
        static int CompareCourseAge(Student st1, Student st2)
        {
            if (st1.course < st2.course)
                return -1;
            else if (st1.course > st2.course)
                return 1;
            else
            {
                if (st1.age <= st2.age)
                    return -1;
                else return 1;
            }
        }

        /// <summary>
        /// Сравнение по курсу
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int CompareCourse(Student st1, Student st2)
        {
            return st1.course < st2.course ? -1 : 1;         
        }

        /// <summary>
        /// Сравнение по возрасту
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int CompareAge(Student st1, Student st2)           //в) отсортировать список по возрасту студента;
        {
            return st1.age < st2.age ? -1 : 1;
        }

        /// <summary>
        /// Частотный массив по курсам
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        static int[] Freq(List<Student> list)
        {
            int[] freq = new int[7];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].age <= 20 && list[i].age >= 18) freq[list[i].course]++;
            }
            return freq;
        }
    }

}
