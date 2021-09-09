using System;

namespace Uppgifter210906X9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv antalet tal du vill sortera.");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] numArr = new int[num];

            for (int i = 0; i < numArr.Length; i++)
            {
                Console.WriteLine("Skriv en siffra.");
                numArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var number in numArr)
            {
                Console.WriteLine(number);
            }

            int temp;
            for (int j = 0; j <= numArr.Length - 2; j++)
            {
                for (int i = 0; i <= numArr.Length - 2; i++)
                {
                    if (numArr[i] > numArr[i + 1])
                    {
                        temp = numArr[i + 1];
                        numArr[i + 1] = numArr[i];
                        numArr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Dina lista sorterad:");
            foreach (int number in numArr)
                Console.Write(number + " ");
        }
    }
}