using System;

namespace CSKodOvningarB
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordCount = 0, index = 0;

            Console.WriteLine("Skriv nedan ditt favoritcitat som är minst fem ord långt: ");
            string citat = Console.ReadLine();

            // skip whitespace until first word
            while (index < citat.Length && char.IsWhiteSpace(citat[index]))
                index++;

            while (index < citat.Length)
            {
                // check if current char is part of a word
                while (index < citat.Length && !char.IsWhiteSpace(citat[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < citat.Length && char.IsWhiteSpace(citat[index]))
                    index++;
            }
            Console.WriteLine("Ditt citat består av " + wordCount + " ord.");

            string[] words = citat.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
