using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Илья Бугров
//2. Разработать статический класс Message, содержащий следующие статические методы для
//обработки текста:
//а) Вывести только те слова сообщения,  которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

namespace Lesson5
{
    static class Message
    {
        static void PrintWords(string message, int n)
        {
            string[] ss = message.Split(' ');
            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].Length < n)
                {
                    Console.WriteLine(ss[i]);
                }
            }
        }

        static void DeleteWords(ref string message, char chr)
        {
            string[] ss = message.Split(' ');
            for (int i = 0; i < ss.Length; i++)
            {
                if(ss[i][ss[i].Length-1] == chr)
                {
                    ss[i] = "";
                }
            }
            message = String.Join(" ", ss);
        }

        static string LongestWord(string message)
        {
            string[] ss = message.Split(' ');
            string longestWord = "";
            int maxLength = 0;
            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].Length > maxLength)
                {
                    longestWord = ss[i];
                    maxLength = ss[i].Length;
                }
            }
            return longestWord;
        }

        static string LongWords(string message)
        {
            StringBuilder a = new StringBuilder();
            string[] ss = message.Split(' ');
            int maxLength = 0;

            for(int i = 0; i < ss.Length; i++)
            {
                if (ss[i].Length > maxLength)
                {
                    maxLength = ss[i].Length;
                }
            }

            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].Length == maxLength)
                {
                    a.Append(ss[i]);
                    a.Append(" ");
                }
            }

            return a.ToString();
        }

    }
}
