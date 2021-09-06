using System;

namespace GrundernaCSProgramstrukturKasiem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många favoirtmaträtter har du? TEST");
            int index = Convert.ToInt32(Console.ReadLine());
            string[] foods = new string[index];

            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine("Mata in en av dina favoirtmaträtter: ");
                foods[i] = Console.ReadLine();
            }

            Console.Write("Dina favoritmaträtter är: ");

            for (int i = 0; i < foods.Length; i++)
            {
                Console.Write(foods[i] + " ");
            }

            for (int i = 0; i < foods.Length; i++)
            {
                Console.Write("\n" + foods[i] + " är (" + foods[i].Length + ") bokstäver lång.");
            }

            string longest = foods[0];

            for (int i = 0; i < foods.Length - 1; i++)
            {
                if (foods[i].Length < foods[i + 1].Length)
                {
                    longest = foods[i + 1];
                    Console.WriteLine("Test");
                }
            }
            Console.WriteLine("\nMaträtten med mest bokstäver är: " + longest);
        }
    }
}