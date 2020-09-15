using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

//Семиков Сергей

//**Считайте файл различными способами. Смотрите “Пример записи файла различными способами”. 
//Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), 
//строку для StreamReader и массив int для BinaryReader.

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            long size = 1024;

            //Console.WriteLine("FileStream. Milliseconds:{0}", FileStreamSample("bigdata0.bin", size));
            //Console.WriteLine("BinaryStream. Milliseconds:{0}", BinaryStreamSample("bigdata1.bin", size));
            //Console.WriteLine("StreamWriter. Milliseconds:{0}", StreamWriterSample("bigdata2.bin", size));
            //Console.WriteLine("BufferedStream. Milliseconds:{0}", BufferedStreamSample("bigdata3.bin", size));

            byte[] fs = FileStream("bigdata0.bin", size);           //массив byte (FileStream)
            byte[] bs = BufferedStream("bigdata3.bin", size);       //массив byte (BufferedStream)
            string str = StreamReader("bigdata2.bin", size);        //строку для StreamReader
            int[] br = BinaryStream("bigdata1.bin", size);          //массив int для BinaryReader

            Console.ReadKey();
        }
        /// <summary>
        /// Массив byte (FileStream)
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        static byte[] FileStream(string filename, long size)
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            byte[] temp = new byte[fs.Length/sizeof (byte)];
            for (int i = 0; i < fs.Length / sizeof(byte); i++)
                temp[i] = Convert.ToByte(fs.ReadByte());
            fs.Close();
            return temp;
        }

        /// <summary>
        /// Массив byte (BufferedStream)
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        static byte[] BufferedStream(string filename, long size)
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            int countPart = 4;
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            for (int i = 0; i < countPart; i++)
                buffer[i] = Convert.ToByte(bs.ReadByte());
            fs.Close();
            return buffer;
        }

        /// <summary>
        /// Массив int для BinaryReader
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        static int[] BinaryStream(string filename, long size)
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(fs);
            int[] temp = new int[fs.Length / sizeof(Int32)];
            for (int i = 0; i < fs.Length / sizeof(Int32); i++)
                temp[i] = br.ReadInt32();
            fs.Close();
            return temp;
        }

        /// <summary>
        /// Строка для StreamReader
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        static string StreamReader(string filename, long size)
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string str = "";
            //for (int i = 0; i < fs.Length; i++)
                str = sr.ReadToEnd();
            fs.Close();
            return str;
        }



        //Методы для заполнения случайными значениями

        static long FileStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Random r = new Random();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            //FileStream fs = new FileStream("D:\\temp\\bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                fs.WriteByte(Convert.ToByte(r.Next(8)));
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }


        static long BinaryStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Random r = new Random();
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < size; i++)
                bw.Write(Convert.ToByte(r.Next(8)));
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }


        static long StreamWriterSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Random r = new Random();
            FileStream fs = new FileStream(filename, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < size; i++)
                sw.Write(r.Next(8));
            sw.Close();
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }


        static long BufferedStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Random r = new Random();
            FileStream fs = new FileStream(filename, FileMode.Create);
            int countPart = 4;
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            for (int i = 0; i < size; i++)
                buffer[i] = Convert.ToByte(r.Next(8));
            BufferedStream bs = new BufferedStream(fs, bufsize);
            for (int i = 0; i < countPart; i++)
                bs.Write(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

    }
}
