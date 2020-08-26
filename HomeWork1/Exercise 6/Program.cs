using System;
//Семиков Сергей

//*Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

namespace Exercise_6
{
    class Program
    {

        static void Pause()
        {
            Console.ReadKey();
        }

        static void Print(string a)
        {
            Console.WriteLine(a);
        }

        static void Clear()
        {
            Console.Clear();
        }
        static void CursorToStart()
        {
            Console.SetCursorPosition(0, 0);
        }
        static void Main(string[] args)
        {   

            Console.WriteLine("Hello World!");
            long x = -20405980915798257;
            Pause();
            Print(Convert.ToString(x));
            Pause();
            CursorToStart();
            Pause();
            Print("asdasd");
            Pause();
            Clear();
            Pause();

        }
    }
}
