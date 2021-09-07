using System;
//Låt användaren mata in en mening.
//Skriv ut varje ord på en egen rad, i storleksordning (längd på ordet)
//Skriv ut varje ord på en egen rad, i omvänd ordning (baklänges)

namespace U210906X2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");//I princip skapar en ny variabel efter varje " " och sparar den. 

            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));//Sorterar alla variabler som finns i "word" efter antalet karaktärer den har.

            Console.WriteLine("Orden du skrev in kommer nu skrivas ut sorterade i stigande ordning beroende på längden av varje ord: ");

            foreach (var word in words)//Skapar en ny variabel "word". För varje variabel i listan words skapas en ny word variabel.
            {
                Console.WriteLine($"{word}");//Word variabeln skrivs ut.
            }

            Array.Sort(words, (y, x) => x.Length.CompareTo(y.Length));//Sorterar alla variabler som finns i "word" efter antalet karaktärer den har. Denna gång i omvänd ordning från förra.

            Console.WriteLine("Orden du skrev in kommer nu skrivas ut sorterade i fallande ordning beroende på längden av varje ord: ");

            foreach (var word in words)
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}