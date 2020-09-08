using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Семиков Сергей

//*а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, 
//    заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов 
//    массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный 
//    элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер 
//    максимального элемента массива (через параметры, используя модификатор ref или out).
//**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
//**в) Обработать возможные исключительные ситуации при работе с файлами.

namespace Exercise_5
{
    class Arr
    {
        private int[,] temp;
        private int sizeX, sizeY;
        private int sum, summore, max;
        private double maxIndexX, maxIndexY;
        private string maxIndex;
        public Arr()
        {
            temp = new int[1,1];
            sizeX = 0;
            sizeY = 0;
        }
        public Arr(int value)
        {
            temp = new int[value,value];
            sizeX = value;
            sizeY = value;
        }
        public Arr(int valueX, int valueY)
        {
            temp = new int[valueX, valueY];
            sizeX = valueX;
            sizeY = valueY;
        }
        public Arr(string path)
        {
            StreamReader sr = new StreamReader(path);
            temp = new int[sizeX,sizeY];
            sizeX = 0;
            sizeY = 0;
            for (int i = 0; !sr.EndOfStream; i++)
            {
                var arr = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in arr)
                {
                    int j = 0;
                    int t;
                    var res = int.TryParse(item, out t);
                    if (res) temp[i,j++] = t;
                }
            }
            //while (!sr.EndOfStream)
            //{
            //    //int t = Convert.ToInt32(sr.ReadLine().Split(' '));
            //    //var res = int.TryParse(sr.ReadLine().Split(' '), out t);
            //    //Add(t);
            //}
            sr.Close();
        }

        public int this[int indexX, int indexY]
        {
            get { return temp[indexX,indexY]; }
            set { temp[indexX, indexY] = value; }
        }

        public int Sum 
        { get 
            {
                int sum = 0;

                for (int i = 0; i < sizeX; i++)
                {
                    for (int j = 0; j < sizeY; j++)
                        sum += temp[i, j];
                }
                return sum;
            } 
        }       //Сумма всех элементов
        public int Min 
        { 
            get 
            {
                int min = Int32.MaxValue;

                for (int i = 0; i < sizeX; i++)
                    for (int j = 0; j < sizeY; j++)
                        if (temp[i, j] < min) min = temp [i,j];
                return min; 
            }
        }       //Минимальное значение массива
        public int Max
        {
            get
            {
                int max = Int32.MinValue;

                for (int i = 0; i < sizeX; i++)
                    for (int j = 0; j < sizeY; j++)
                        if (temp[i, j] > max) max = temp[i, j];
                return max;
            }
        }       //Максимальное значение массива
        public string MaxIndex
        {
            get
            {
                int max = Int32.MinValue;

                for (int i = 0; i < sizeX; i++)
                    for (int j = 0; j < sizeY; j++)
                        if (temp[i, j] > max)
                        {
                            max = temp[i, j];
                            maxIndexX = i;
                            maxIndexY = j;
                            maxIndex = $"Индекс максимального элемента:\n{i} {j}";
                        }
                return maxIndex;
            }
        }

        public int MaxCount { get { return MaxCounter(); } }

        public int Count1 { get { return sizeX; } }
        public int Count2 { get { return sizeY; } }

        //public void Add(int item)
        //{
        //    if (temp.Length <= size) Array.Resize(ref temp, temp.Length + 1);
        //    if (temp[size] == temp.Max()) maxcount++;
        //    temp[size++] = item;
        //}
       
        public int InputRandLast()
        {
            bool res = false;
            int last = 1;
            Console.WriteLine("Какое максимальное значение может принимать элемент массива?");
            Try(ref res, ref last);
            return last;
        }
        public int InputMore()
        {
            bool res = false;
            int last = 1;
            Console.WriteLine("Посчитать сумму всех элементов массива больше заданного. Какого?");
            Try(ref res, ref last);
            return last;
        }
        public void FillRand(int last)
        {
            Random rand = new Random();
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    temp[i,j] = rand.Next(last + 1);
                }
            }
        }
        public int Try(ref bool res, ref int input)
        {
            int t=0;
            while (!res)
            {
                res = int.TryParse(Console.ReadLine(), out t);
                if (!res) Console.WriteLine("Неверный формат");
            }
            return t;
        }
        public void MaxCountOutput(int maxcount)
        {
            Console.WriteLine($"Количество максимальных элементов \n\n{maxcount,5}\n");
        }

        public void Output()
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    Console.Write($"{ temp[i,j],5}");
                }
                Console.WriteLine();
            }
        }
        public void Multi(int factor)
        {
            for (int i = 0; i < temp.Length; i++) temp[i] *= factor;
        }
        public void SumOutput(int sum)
        {
            Console.WriteLine($"\n{sum,5}\n");
        }
        public int SumMore(int min)
        {
            int sumMore = 0;

            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                    if (temp[i, j] > min) sumMore += temp[i, j];

            return sumMore;
        }
        public void SumMoreOutput(int sumMore)
        {
            Console.WriteLine($"\n{sumMore,5}\n");
        }
       
        //public int MaxCounter()

        //{
        //    maxcount = 0;
        //    max = temp.Max();
        //    for (int i = 0; i < temp.Length; i++)
        //        if (temp[i] == max) maxcount++;
        //    return maxcount;

        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            Arr mas = new Arr(5, 5);
            mas.FillRand(mas.InputRandLast());      //заполняем рандомом
            mas.Output();
            mas.SumOutput(mas.Sum);                 //Сумма всех элементов массива
            mas.SumMoreOutput(mas.InputMore());     //Сумма всех элементов массива больше заданного

        }
    }
}
