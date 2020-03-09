﻿// Дана строка длины N.Найти подстроку-палиндром с максимальной длиной.
// Результат:
// 1. Реализованный алгоритм (ссылка на репозиторий, другое)
// 2. Провести асимптотический анализ реализованного алгоритма 

using System;

namespace Task3
{
    class Task_3
    {
        static void Main(string[] args)
        {
            string text = "fds lol шалаш lol";
            Console.WriteLine(FindMaxPalindrom(text));
            Console.ReadLine();
        }

        static string FindMaxPalindrom(string text)                     // итого асимптотическая сложность алгоритма составляет O(n)
        {
            string[] splittedText = text.Split(' ', ',', '.');
            string longestPalindrom = "";

            foreach (var word in splittedText)                          // O(n)
            {
                if (IsPalindrom(word))                                  // O(1)
                {
                    longestPalindrom = word.Length > longestPalindrom.Length ? word : longestPalindrom;
                }
            }

            return longestPalindrom;
        }

        static bool IsPalindrom(string word)
        {
            bool flag = false;
            for (int i = 0; i <= word.Length / 2; i++)                  // O(log n)
            {
                if (word[i] == word[word.Length - i - 1])               // O(1)
                {
                    flag = word[i] == word[word.Length - i - 1];
                }

                return flag;
            }

            return flag;
        }
    }
}
