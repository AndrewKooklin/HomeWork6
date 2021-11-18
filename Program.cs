using System;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Разделение строки на слова.");

            PrintWords(SplitWords());

            Console.WriteLine();

            // Задание 2
            Console.WriteLine("Реверс слов в предложении.");

            PrintWords(ReversWords(SplitWords()));

            Console.ReadLine();
        }

         //Задание 1
         static string[] SplitWords()
        {
            Console.WriteLine("Введите предложение разделяя слова пробелом.");
            string Sentence = Console.ReadLine();
            string [] words = Sentence.Split(" ");
            return words;
        }

        static void PrintWords(string [] words)
        {
            foreach(var word in words) { 
            Console.WriteLine(word);
            }
        }

        // Задание 2

        static string[] ReversWords(string[] words)
        {
            string ResultString = "";
            for (int i=words.Length-1; i>=0; i--)
            {
               ResultString += words[i]+" ";
            }
            string[] wordsResult = ResultString.Split(" ");
            return wordsResult ;
        }

    }
}
