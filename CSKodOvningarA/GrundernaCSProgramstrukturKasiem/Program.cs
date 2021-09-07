using System;

namespace GrundernaCSProgramstrukturKasiem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många favoirtmaträtter har du?");
            int index = Convert.ToInt32(Console.ReadLine());
            string[] foods = new string[index];//Skapar en array med lika många variabler som användaren matade in i raden ovan.

            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine("Mata in en av dina favoirtmaträtter: ");
                foods[i] = Console.ReadLine();//Varje ord som matas in tilldelas en variabel i arrayen foods.
            }

            Console.Write("Dina favoritmaträtter är: ");//Skrivs utanför for för att inte upprepas för varje maträtt.

            for (int i = 0; i < foods.Length; i++)
            {
                Console.Write(foods[i] + " ");//Skriver ut alla maträtter.
            }

            for (int i = 0; i < foods.Length; i++)
            {
                Console.Write("\n" + foods[i] + " är (" + foods[i].Length + ") bokstäver lång.");//Skriver antalet bokstäver för varje maträtt genom att räkna antalet variabler för varje karaktär
            }

            string longest = foods[0];//Skapar den innan for loopen så att den kan användas i slutet.

            for (int i = 0; i < foods.Length - 1; i++)//Eftersom arrayen börjar på 0 måste 1 subtraheras.
            {
                if (foods[i].Length < foods[i + 1].Length)
                {
                    longest = foods[i + 1];//Longest tilldelas ett nytt värde för varje gång loopen körs och if statsen är true.
                }
            }
            Console.WriteLine("\nMaträtten med mest bokstäver är: " + longest);
        }
    }
}