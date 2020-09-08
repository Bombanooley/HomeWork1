using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Семиков Сергей

//Дан целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  
//    значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  Написать 
//    программу, позволяющую найти и вывести количество пар элементов массива, в которых 
//    только одно число делится на 3. В данной задаче под парой подразумевается два подряд 
//    идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

//Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать 
//    массив целых чисел;
//в)**Добавьте обработку ситуации отсутствия файла на диске.


namespace Exercise1
{
    class Arr
    {
        int[] temp;
        int size;

        public Arr()
        {
            temp = new int[1];
            size = 0;
        }

        public Arr(int count)
        {
            temp = new int[count];
            size = count;
        }
        public Arr(string path)
        {
            StreamReader sr = new StreamReader(path);
            temp = new int[1];
            size = 0;
            
                var arr = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in arr)
                {
                    int t;
                    var res = int.TryParse(item, out t);
                    if (res) Add(t);
                }
            //while (!sr.EndOfStream)
            //{
            //    //int t = Convert.ToInt32(sr.ReadLine().Split(' '));
            //    //var res = int.TryParse(sr.ReadLine().Split(' '), out t);
            //    //Add(t);
            //}
            sr.Close();

            

        }
        public void SaveToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < size; i++)
            {
                sw.Write($"{temp[i].ToString()} ");
            }
            sw.Close();
        }
        public void Add(int item)
        {
            if (temp.Length <= size) Array.Resize(ref temp, temp.Length + 1);
            temp[size++] = item;
           
        }
        public int Count { get { return size;} }

        public int this[int index]
        {
            get { return temp[index]; }
            set { temp[index] = value; }
        }
        public void Fill()
        {
            Random rand = new Random();
            for (int i = 0; i < temp.Length; i++) temp[i] = rand.Next(-10000, 10001);
        }
        public void Fill(int length)
        {
            Random rand = new Random();
            size = length;
            Array.Resize(ref temp, length);
            for (int i = 0; i < length; i++) temp[i] = rand.Next(-10000, 10001);
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < temp.Length - 1; i++)
            {
                if (
                   (temp[i] % 3 == 0 && temp[i + 1] % 3 != 0) ||
                   (temp[i] % 3 != 0 && temp[i + 1] % 3 == 0))
                    sum++;
            }
            return sum;
        }

        public void SumOutput(int sum)
        {
            Console.WriteLine($"\n{sum,5}\n");
        }

        public void Output()
        {
            for (int i = 0; i < temp.Length; i++) Console.WriteLine($"{ temp[i],5}");
            Console.WriteLine();
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Array.txt";
            int length = 20;
            Arr Arr= new Arr(length);
            Arr = new Arr(path);
            Arr.Output();
            Arr.Fill(length);
            int sum = Arr.Sum();
            Arr.Output();
            Arr.SumOutput(sum);
            Arr.SaveToFile(path);

            Console.ReadKey();
        }
    }
}
