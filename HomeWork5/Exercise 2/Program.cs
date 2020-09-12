using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Семиков Сергей

//Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается 
//    массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит
//    в этот текст. Здесь требуется использовать класс Dictionary.

namespace Exersice_2
{

    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string text = Input();

            int max = InputMax();
            Message.CheckLess(text, max);

            char last = InputChar();
            Message.DeleteLast(text, last);

            Console.WriteLine($"Самое длинное слово: ");
            Message.Longest(text);

            Console.WriteLine($"Самые длинные слова: ");
            Message.LongWords(text);

            string[] AllowWords = { "as", "asd", "a" };
            AllowWordsCheck(count, text, AllowWords);
            Pause();
        }

        /// <summary>
        /// Частотный массив заданных слов
        /// </summary>
        /// <param name="count">В данном случае - не используется</param>
        /// <param name="text">Текст</param>
        /// <param name="AllowWords">Массив допустимых слов</param>
        private static void AllowWordsCheck(int count, string text, string [] AllowWords)
        {
            
            string[] Words = Message.Words(text, ref count);

            Dictionary<string, int> freq = new Dictionary<string, int>();
            foreach (var item in AllowWords)
            {
                if (!freq.ContainsKey(item)) freq.Add(item, 0);
            }
            foreach (var item in Words)
                foreach (var AllowItem in AllowWords)
                    if (item == AllowItem) freq[item]++;
            OutputDic(freq);
        }
        /// <summary>
        /// Вывод словаря
        /// </summary>
        /// <param name="array">Словарь</param>
        private static void OutputDic(Dictionary<string,int> array)
        {
            Console.WriteLine("Частотный массив");
            foreach (var item in array)
                Console.WriteLine($"{item}");
        }
        /// <summary>
        /// Ввод текста
        /// </summary>
        /// <returns></returns>
        private static string Input()
        {
            Console.WriteLine("Введите текст:");
            return Console.ReadLine();
        }

        /// <summary>
        /// Ввод максимального размера слова
        /// </summary>
        /// <returns></returns>
        private static int InputMax()
        {
            Console.Write("Какой максимальный размер слова? ");
            return Try();

        }

        /// <summary>
        /// Ввод символа
        /// </summary>
        /// <returns>Символ</returns>
        private static char InputChar()
        {
            char l = 'a';
            bool res = false;
            Console.Write("На какую букву не должно заканчиваться слово? ");
            while (!res)
            {
                l = Console.ReadKey(true).KeyChar;
                Console.WriteLine(l);
                if (!char.IsLetter(l)) Console.WriteLine("Неверный формат");
                else res = true;
            }
            return l;
        }

        /// <summary>
        /// Проверка ввода числа
        /// </summary>
        /// <returns></returns>
        private static int Try()
        {
            bool res = false;
            int t = 0;
            while (!res)
            {
                res = int.TryParse(Console.ReadLine(), out t);
                if (!res) Console.WriteLine("\nНеверный формат");
            }
            return t;
        }

        /// <summary>
        /// Пауза
        /// </summary>
        private static void Pause()
        {
            Console.ReadKey();
        }
    }
}
