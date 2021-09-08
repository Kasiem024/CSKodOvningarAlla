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

            Array.Sort(words, (word1, word2) => word1.Length.CompareTo(word2.Length));//Sorterar alla variabler som finns i "word" efter antalet karaktärer den har. Jämför alla med alla.

            Console.WriteLine("Orden du skrev in kommer nu skrivas ut sorterade i stigande ordning beroende på längden av varje ord: ");

            foreach (var word in words)//Skapar en ny variabel "word". För varje variabel i listan words skapas en ny word variabel.
            {
                Console.WriteLine($"{word}");//Word variabeln skrivs ut.
            }

            Array.Sort(words, (word2, word1) => word1.Length.CompareTo(word2.Length));//Sorterar alla variabler som finns i "word" efter antalet karaktärer den har. Denna gång i omvänd ordning från förra.

            Console.WriteLine("Orden du skrev in kommer nu skrivas ut sorterade i fallande ordning beroende på längden av varje ord: ");

            foreach (var word in words)
            {
                Console.WriteLine($"{word}");
            }

            /*
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're
                    // equal.
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater.
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y == null)
                // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the
                    // lengths of the two strings.
                    //
                    int retval = x.Length.CompareTo(y.Length);

                    if (retval != 0)
                    {
                        // If the strings are not of equal length,
                        // the longer string is greater.
                        //
                        return retval;
                    }
                    else
                    {
                        // If the strings are of equal length,
                        // sort them with ordinary string comparison.
                        //
                        return x.CompareTo(y);
                    }
                }
            }*/
        }
    }
}
//Har försökt hitta ett sätt utan Array.Sort Men det var antaligen svårare än sättet som jag använder just nu.