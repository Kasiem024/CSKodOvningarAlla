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
            String[] words = sentence.Split(" ");//I princip skapar en ny variabel efter varje " " och sparar den.

            Console.WriteLine("Du har skrivit " + words.Length + " ord.");

            foreach (var word in words)//Skapar en ny variabel "word". För varje variabel i listan words skapas en ny word variabel.
            {
                Console.WriteLine($"{word} är ("+word.Length+") bokstäver långt.");//Word variabeln skrivs ut.
            }
        }
    }
}