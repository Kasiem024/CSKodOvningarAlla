using System;
//Låt användaren mata in ett ord i taget
//Avsluta programmet om användaren matar in AVSLUTA
//Skriv ut din mening just nu är: skriv ut alla inmatade ord
//en if else loop som avslutas när ordet AVSLUTA matas in. Alla ord måste också sparas för att sedan skrivas ut.

namespace U210906X5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Du kan nu mata in ett ord om taget. När du vill avsluta programmet skriv: 'AVSLUTA'.");
            string words = "noll";

            if (words != "AVSLUTA")
            {
                words = Console.ReadLine();
            }
        }
    }
}
