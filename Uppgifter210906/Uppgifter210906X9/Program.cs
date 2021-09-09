using System;

namespace Uppgifter210906X9
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int[] numArr = new int [num.Length];

            for (int i = 0; i < num.Length - 1; i++)
            {
                num[i] = numArr[i];
            }

        }
    }
}