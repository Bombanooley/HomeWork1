using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr
{
    public class Arr
    {
        private int[] temp;
        private int size;
        private int sum, maxcount, max;
        public Arr()
        {
            temp = new int[1];
            size = 0;
        }
        public Arr(int value)
        {
            temp = new int[value];
            size = value;
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

        public int this[int index]
        {
            get { return temp[index]; }
            set { temp[index] = value; }
        }

        public int Sum { get { return Summ(); } }

        public int MaxCount { get { return MaxCounter(); } }

        public int Count { get { return size; } }

        public void Add(int item)
        {
            if (temp.Length <= size) Array.Resize(ref temp, temp.Length + 1);
            if (temp[size] == temp.Max()) maxcount++;
            temp[size++] = item;
        }
        public void FillStep(int step)
        {

            max = temp.Max();
            sum = temp[0];
            for (int i = 1; i < temp.Length; i++)
                temp[i] = temp[i - 1] + step;
        }
        public void FillRand(int length, int last)
        {
            Random rand = new Random();
            size = length;
            Array.Resize(ref temp, length);
            for (int i = 0; i < length; i++) temp[i] = rand.Next(last + 1);
        }
        public void MaxCountOutput(int maxcount)
        {
            Console.WriteLine($"Количество максимальных элементов \n\n{maxcount,5}\n");
        }
        public void SumOutput(int sum)
        {
            Console.WriteLine($"\n{sum,5}\n");
        }

        public void FreqOutput()
        {
            Arr freq = Freq();
            Console.WriteLine("\nЧастотный массив:\n");
            for (int i = 0; i < freq.Count; i++) Console.WriteLine($"{i,3} - { freq[i],5}");
        }
        public void Output()
        {
            for (int i = 0; i < temp.Length; i++) Console.WriteLine($"{ temp[i],5}");
            Console.WriteLine();
        }
        public void Multi(int factor)
        {
            for (int i = 0; i < temp.Length; i++) temp[i] *= factor;
        }
        public Arr Freq()
        {
            Arr freq = new Arr(temp.Max() + 1);
            for (int i = 0; i < temp.Length; i++)
                freq[temp[i]]++;
            return freq;
        }
        public int Summ()
        {
            int sum = 0;
            for (int i = 0; i < temp.Length; i++) sum += temp[i];
            return sum;
        }
        public int MaxCounter()
        {
            maxcount = 0;
            max = temp.Max();
            for (int i = 0; i < temp.Length; i++)
                if (temp[i] == max) maxcount++;
            return maxcount;

        }
    }
}

