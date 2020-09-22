using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

//Семиков Сергей

//С помощью рефлексии выведите все свойства структуры DateTime

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type DateTime = typeof(DateTime);
        
            foreach (MemberInfo item in DateTime.GetProperties())
                Console.WriteLine($"{item.DeclaringType} {item.MemberType} {item.Name}");

            Console.ReadKey();
        }
    }
}
