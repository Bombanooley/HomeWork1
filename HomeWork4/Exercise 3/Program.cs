using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Arr; //б)**Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки

//Семиков Сергей

//а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив 
//    определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
//    Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий 
//    новый массив с измененными знаками у всех элементов массива (старый массив, остается без 
//    изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство 
//    MaxCount, возвращающее количество максимальных элементов. 
//б)**Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
//е) ***Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)

namespace Exercise_2
{
    //Тут разрабатывал библиотеку

    //class Arr
    //{
    //    private int[] temp;
    //    private int size;
    //    private int sum, maxcount, max;
    //    public Arr()
    //    {
    //        temp = new int[1];
    //        size = 0;
    //    }
    //    public Arr(int value)
    //    {
    //        temp = new int[value];
    //        size = value;
    //    }
    //    public Arr(string path)
    //    {
    //        StreamReader sr = new StreamReader(path);
    //        temp = new int[1];
    //        size = 0;

    //        var arr = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    //        foreach (var item in arr)
    //        {
    //            int t;
    //            var res = int.TryParse(item, out t);
    //            if (res) Add(t);
    //        }
    //        //while (!sr.EndOfStream)
    //        //{
    //        //    //int t = Convert.ToInt32(sr.ReadLine().Split(' '));
    //        //    //var res = int.TryParse(sr.ReadLine().Split(' '), out t);
    //        //    //Add(t);
    //        //}
    //        sr.Close();



    //    }

    //    public int this[int index]
    //    {
    //        get { return temp[index]; }
    //        set { temp[index] = value; }
    //    }

    //    public int Sum { get { return Summ(); } }

    //    public int MaxCount { get { return MaxCounter(); } }

    //    public int Count { get { return size; } }

    //    public void Add(int item)
    //    {
    //        if (temp.Length <= size) Array.Resize(ref temp, temp.Length + 1);
    //        if (temp[size] == temp.Max()) maxcount++;
    //        temp[size++] = item;
    //    }
    //    public void FillStep(int step)
    //    {
            
    //        max = temp.Max();
    //        sum = temp[0];
    //        for (int i = 1; i < temp.Length ; i++)
    //            temp[i] = temp[i - 1] + step;
    //    }
    //    public void FillRand(int length, int last)
    //    {
    //        Random rand = new Random();
    //        size = length;
    //        Array.Resize(ref temp, length);
    //        for (int i = 0; i < length; i++) temp[i] = rand.Next(last+1);
    //    }
    //    public void MaxCountOutput(int maxcount)
    //    {
    //        Console.WriteLine($"Количество максимальных элементов \n\n{maxcount,5}\n");
    //    }
    //    public void SumOutput(int sum)
    //    {
    //        Console.WriteLine($"\n{sum,5}\n");
    //    }

    //    public void FreqOutput()
    //    {
    //        Arr freq = Freq();
    //        Console.WriteLine("\nЧастотный массив:\n");
    //        for (int i = 0; i < freq.Count; i++) Console.WriteLine($"{i,3} - { freq[i],5}");
    //    }
    //    public void Output()
    //    {
    //        for (int i = 0; i < temp.Length; i++) Console.WriteLine($"{ temp[i],5}");
    //        Console.WriteLine();
    //    }
    //    public void Multi(int factor)
    //    {
    //        for (int i = 0; i < temp.Length; i++) temp[i] *= factor;
    //    }
    //    public Arr Freq()
    //    {
    //        Arr freq = new Arr(temp.Max()+1);
    //        for (int i = 0; i < temp.Length; i++)
    //            freq[temp[i]]++;
    //        return freq;
    //    }
    //    public int Summ()
    //    {
    //        int sum = 0;
    //        for (int i = 0; i < temp.Length; i++) sum += temp[i];
    //        return sum;
    //    }
    //    public int MaxCounter()
    //    {
    //        maxcount = 0;
    //        max = temp.Max();
    //        for (int i = 0; i < temp.Length; i++)
    //          if (temp[i] == max) maxcount++;
    //        return maxcount;

    //    }

    //}
    class Program
    {
        static void Main(string[] args)
        {
            int length = InputLength();  //     Заполняем массив
            Arr.Arr ma = new Arr.Arr(length);

            ma[0] = InputStart();
            int first = ma[0];
            ma.FillStep(InputStep());
            ma.Output();


            ma.SumOutput(ma.Sum);       //      Создать свойство Sum,

            Arr.Arr maInv = Inverse(ma);    //      Инверсия знаков
            maInv.Output();

            ma.Multi(InputFactor());    //      Умножаем элементы
            ma.Output();


            //// Cвойство MaxCount, возвращающее количество максимальных элементов. 
            //ma.MaxCountOutput(ma.MaxCount);

            ////е) ***Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
            ma.FillRand(length, InputRandLast());

            ma.FreqOutput();
            
            Console.ReadKey();
        }

      
        
        private static Arr.Arr Inverse(Arr.Arr sourse)
        {
            Arr.Arr temp = new Arr.Arr(sourse.Count);
            for (int i = 0; i < sourse.Count; i++) temp[i] = -sourse[i];
            return temp;

        }
        private static int InputFactor()
        {
            bool res = false;
            int factor = 0;
            Console.WriteLine("На какое число уможить каждый элемент массива?");
            Try(ref res, ref factor);
            return factor;
        }
        private static int InputStart()
        {
            bool res = false;
            int start = 0;
            Console.WriteLine("Какое начально значение?");
            Try(ref res, ref start);
            return start;
        }
        private static int InputStep()
        {
            bool res = false;
            int step = 1;
            Console.WriteLine("Какой шаг?");
            Try(ref res, ref step);
            return step;
        }
        private static int InputRandLast()
        {
            bool res = false;
            int last = 1;
            Console.WriteLine("Какое максимальное значение может принимать элемент массива?");
            Try(ref res, ref last);
            return last+1;
        }
        private static int InputLength()
        {
            bool res = false;
            int length = 1;
            Console.WriteLine("Сколько элементов будет в массиве?");
            Try(ref res, ref length);
            return length;
        }

        private static void Try(ref bool res, ref int length)
        {
            while (!res)
            {
                res = int.TryParse(Console.ReadLine(), out length);
                if (!res) Console.WriteLine("Неверный формат");
            }
        }
        
    }
}
