using System;
using System.Text;

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
    /// <summary>
    /// Класс, содержащий статические методы
    /// </summary>
    static class Message
    {
        /// <summary>
        /// Считываем слова
        /// </summary>
        /// <param name="input">Текст</param>
        /// <returns>Массив, где каждый элемент - отдельное слово</returns>
        
        public static string[] Words(string input, ref int count)
        {
            string[] words = new string[input.Length / 2 + 1];
            string temp = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i])) temp += input[i];
                else if (temp != "")
                { words[count++] = temp; temp = ""; }
            }
            words[count++] = temp;
            return words;
        }

        /// <summary>
        /// Проверяем и выводим слова, которые содержат не более n букв
        /// </summary>
        /// <param name="input">Текст</param>
        /// <param name="max">Максимально допустимый размер слова</param>
        public static void CheckLess(string input, int max)
        {
            int count = 0;
            string [] words = Words(input,ref count);
            for (int i = 0; i < count; i++)
                if (words[i].Length <= max)
                    OutputOne(words[i]);
            Console.WriteLine();
        }

        /// <summary>
        /// Вывод одного слова
        /// </summary>
        /// <param name="word">Слово</param>
        public static void OutputOne(string word)
        {
            Console.WriteLine(word);
        }

        /// <summary>
        /// Удаляем и выводим слова, заначивающиеся на определённую букву
        /// </summary>
        /// <param name="input">Текст</param>
        /// <param name="last">На какую букву нельзя заканчивать слово</param>
        public static void DeleteLast(string input, char last)
        {
            int count = 0;
            string[] words = Words(input, ref count);
            for (int i = 0; i < count; i++)
                if (words[i][words[i].Length-1] != last)
                    OutputOne(words[i]);
            Console.WriteLine();
        }

        /// <summary>
        /// Находим и выводим самое длинное слово
        /// </summary>
        /// <param name="input">Текст</param>
        public static void Longest(string input)
        {
            int count = 0, maxlng = 0;
            string lng = "";
            string[] words = Words(input, ref count);
            for (int i = 0; i < count; i++)
            {
                if (words[i].Length > maxlng)
                {
                    lng = words[i];
                    maxlng = words[i].Length;
                }
            }
            Output(lng);
        }

        /// <summary>
        /// Создаём и выводим строку из самых длинных слов
        /// </summary>
        /// <param name="input">Текст</param>
        public static void LongWords(string input)
        {
            int count = 0, maxlng = 0;
            //string lng = "";
            string[] words = Words(input, ref count);
            StringBuilder lng = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                if (words[i].Length > maxlng)
                {
                    lng.Remove(0, lng.Length);
                    lng.Append($"{words[i]} ");
                    maxlng = words[i].Length;
                }
                else if (words[i].Length == maxlng) 
                    lng.Append ($"{words[i]} ");
            }
           
            Output(lng.ToString());
        }

        /// <summary>
        /// Вывод элемента
        /// </summary>
        /// <param name="input">Строка</param>
        public static void Output(string input)
        {
            Console.WriteLine(input+"\n");
        }
    }
}
