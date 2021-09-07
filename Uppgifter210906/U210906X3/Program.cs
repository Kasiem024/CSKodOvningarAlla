using System;
//Låt användaren mata in en mening.
//Skriv ut varje unikt ord på en egen rad, och ange hur ofta ordet förekommer (ex "och (2)")
//Skriv ut varje unikt ord på en egen rad, sorterat efter hur ofta ordet förekommer
//Sortera i alfabetsordning och om de har samma värde är det samma ord. Alltså if else och jämföra alla ord med varandra. Ha en coutner för varje ord.

namespace U210906X3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");

            Array.Sort(words);
            int[] counter = new int[words.Length];

            for (int i = 0; i <= counter.Length - 1; i++)
            {
                counter[i] = 0;
            }

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i].Equals(words[i + 1], StringComparison.OrdinalIgnoreCase))
                {
                    counter[i]++;
                    foreach (var word in words)
                    {
                        Console.WriteLine($"{word} och {counter[i]}");
                    }
                }
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word} och {counter}");
            }

            /*for (int i = 0; i <= sentence.Length - 1; i++)
            {
                if (sentence[i].Length < sentence[i + 1].Length)
                {
                    String Tobematched = words[i];
                    int Count = 0;
                    foreach (Match Match in Regex.Matches(sentence, Tobematched, RegexOptions.IgnoreCase))
                    {
                        Count++;
                    }
                    Console.WriteLine("{0}" + " Found " + "{1}" + " Times", Tobematched, Count);
                }
            }*/
        }
    }
}
