using System;
using System.IO;


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
    /// <summary>
    /// Класс с данными одного студента
    /// </summary>
    class Student
    {
        string surname, name;
        int[] score;

        /// <summary>
        /// Простой конструктор
        /// </summary>
        public Student()
        {
            this.surname = "" ;
            this.name = "";
            score[0] = 1;
            score[1] = 1;
            score[2] = 1;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="surname">Фамилия</param>
        /// <param name="name">Имя</param>
        /// <param name="a">Первая оценка</param>
        /// <param name="b">Вторая оценка</param>
        /// <param name="c">Третья оценка</param>
        public Student(string surname, string name, int a, int b, int c)
        {
            this.surname = surname;
            this.name = name;
            score[0] = a;
            score[1] = b;
            score[2] = c;
        }

        /// <summary>
        /// Считываем из файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        public Student(string path, StreamReader sr)
        {
            var arr = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            surname = arr[0];
            name = arr[1];
            score = new int[3];
            score[0] = Int32.Parse(arr[2]);
            score[1] = Int32.Parse(arr[3]);
            score[2] = Int32.Parse(arr[4]);
        }

        /// <summary>
        /// Индексатор фамилии
        /// </summary>
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        /// <summary>
        /// Индексатор имени
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Индексатор оценок
        /// </summary>
        public int this[int index]
        {
            get { return score[index]; }
            set { score[index] = value; }
        }

        /// <summary>
        /// Получаем средний балл
        /// </summary>
        public double Average { get { return average(score); } }

        /// <summary>
        /// Считаем средний балл
        /// </summary>
        /// <param name="a">Массив оценок</param>
        /// <returns>Средний балл в double</returns>
        double average(int[] a)
        {
            return Convert.ToDouble(a[0] + a[1] + a[2]) / 3;
        }
    }
}
