using System;
//Låt användaren mata in ett ord i taget
//Avsluta programmet om användaren matar in AVSLUTA
//Skriv ut din mening just nu är: skriv ut alla inmatade ord

namespace U210906X5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Du kan nu mata in ett ord om taget. När du vill avsluta programmet skriv: 'AVSLUTA'.");
            string words = "";
            string sentence = "";//Dessa två strings måste skapas utanför loopen så att de kan användas.

            while (words != "AVSLUTA")
            {
                sentence = sentence + words + " ";//Utanför if loopen så att ordet AVSLUTA inte inkluderas i vad som ska skrivas ut.
                if (true)//Behöver ingen statement för att den är inuti while loopen.
                {
                    words = Console.ReadLine();
                }
            }
            Console.WriteLine("Det här är alla orden du matade in: " + sentence);
        }
    }
}