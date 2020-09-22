using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exersice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listS = Read();
            SaveXML(listS, "students_6.xml");

            Console.ReadKey();
        }

        static void SaveXML(List<Student> list, string filename)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
            Stream fstream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            xml.Serialize(fstream, list);
            fstream.Close();
        }
        static List<Student> Read()
        {
            List<Student> list = new List<Student>();
            StreamReader sr = new StreamReader("students_6.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                        break;
                }
            }
            sr.Close();
            return list;
        }
    }
}
