using System;
using System.Text.RegularExpressions;

//Låt användaren mata in en mening.
//Skriv ut varje unikt ord på en egen rad, och ange hur ofta ordet förekommer (ex "och (2)")
//Skriv ut varje unikt ord på en egen rad, sorterat efter hur ofta ordet förekommer
//Sortera i alfabetsordning och om de har samma värde är det samma ord. Alltså if else och jämfra alla ord med varandra.

namespace U210906X3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");


            if (true)
            {

            }
            String Tobematched = words[i];
            int Count = 0;
            foreach(Match Match in Regex.Matches(sentence, Tobematched, RegexOptions.IgnoreCase))
            {
                Count++;
            }
            Console.WriteLine("{0}" + " Found " + "{1}" + " Times", Tobematched, Count);


        }
    }
}
