using System;
//Be användaren gissa ett tal mellan 1-21
//Skapa ett slumptal mellan 1-21 (Se Object Browser Random, Random.Next(1,21) och MSDN)
//Om användaren gissat rätt: skriv ut Grattis!
//Annars fortsätt be användaren gissa

namespace U210906X6
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnd = new Random().Next(1, 21);
            int guess = 0;
            Console.WriteLine("Gissa ett tal mellan 1-21");
            guess = Convert.ToInt32(Console.ReadLine());

            while (guess != rnd)
            {
                while (guess != rnd)
                {
                    Console.WriteLine("Du gissade fel. Försök igen! \nGissa ett tal mellan 1-21");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Du gissade rätt. Grattis!");
        }
    }
}
