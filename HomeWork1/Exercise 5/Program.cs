using System;
//Семиков Сергей

//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) *Сделать задание, только вывод организовать в центре экрана.
//в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
namespace Exercise_5
{
    class Program
    {

        static void Print (int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Семиков Сергей, г. Астрахнь");

        }
        static void Main(string[] args)
        {   
            Console.WriteLine("Семиков Сергей, г. Астрахнь");   //a)

            Console.SetCursorPosition(45, 12);                  //б)
            Console.WriteLine("Семиков Сергей, г. Астрахнь");   
            
            Print(45, 15);                                      //в)
                
            Console.ReadKey();

        }
    }
}
