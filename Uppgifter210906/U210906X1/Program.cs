using System;
//Låt användaren mata in en mening.
//Skriv ut antal ord
//Skriv ut varje ord på en egen rad med antal tecken i ordet (ex hej (3))


namespace U210906X1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening: ");
            String sentence = Console.ReadLine();

            int wordcount = 0;
            int index = 0;

            while (index < sentence.Length && char.IsWhiteSpace(sentence[index]))
                index++;

            while (index < sentence.Length)
            {

                while (index < sentence.Length && !char.IsWhiteSpace(sentence[index]))
                    index++;

                wordcount++;

                while (index < sentence.Length && char.IsWhiteSpace(sentence[index]))
                    index++;
            }
            Console.WriteLine("Du har skrivit " + wordcount + " ord.");

            foreach (var word in sentence)
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}