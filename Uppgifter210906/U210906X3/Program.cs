using System;
using System.Text.RegularExpressions;

//Låt användaren mata in en mening.
//Skriv ut varje unikt ord på en egen rad, och ange hur ofta ordet förekommer (ex "och (2)")
//Skriv ut varje unikt ord på en egen rad, sorterat efter hur ofta ordet förekommer
//Sortera i alfabetsordning och om de har samma värde är det samma ord. Alltså if else och jämföra alla ord med varandra. Ha en coutner för varje ord. Foreach loop där man kollar igenom varje ord. 2D array.

namespace U210906X3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");

            string findMatch;
            int[] counter = new int[words.Length];

            for (int i = 0; i <= words.Length - 1; i++)
            {
                counter[i] = 0;
            }

            for (int i = 0; i <= words.Length - 1; i++)
            {
                findMatch = words[i];
                foreach (Match Match in Regex.Matches(sentence, findMatch, RegexOptions.IgnoreCase))
                {
                    counter[i]++;
                }
            }

            for (int i = 0; i <= words.Length - 2; i++)
            {
                if (words[i] != words[i+1])
                {
                    Console.WriteLine(words[i] + " har skrivits " + counter[i] + " gånger");
                }
            }

            int temp;
            for (int j = 0; j <= counter.Length - 2; j++)
            {
                for (int i = 0; i <= counter.Length - 2; i++)
                {
                    if (counter[i] > counter[i + 1])
                    {
                        temp = counter[i + 1];
                        counter[i + 1] = counter[i];
                        counter[i] = temp;
                    }
                }
            }

            Console.WriteLine("Din lista sorterad:");
            {
                foreach (int number in counter)
                    Console.Write(number + " ");
            }


            /*int[] counter = new int[words.Length];

            for (int i = 0; i <= counter.Length - 1; i++)
            {
                counter[i] = 0;
            }

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == (words[i + 1]))
                {
                    counter[i]++;
                    foreach (var word in words)
                    {
                        Console.WriteLine($"{word} och {counter[i]}");
                    }
                }
            }
            for (int i = 0; i <= counter.Length - 1; i++)
            {
                Console.WriteLine(words[i]+" "+counter[i]);
            }*/
        }
    }
}
