using System;

namespace CSKodOvningarB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt favoirtcitat på minst fem ord: ");
            String quote = Console.ReadLine();
            String[] words = quote.Split(" ");

            Console.WriteLine("Du har skrivit " + words.Length + " ord.");

            foreach (var word in words)
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}