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

            bool needsSorting = true;
            //Gör en loop för varje tal som skall sorteras, avbryt om talen är sorterade
            for (int i = 0; i < numArr.Length - 1 && needsSorting; i++)
            {
                //Signalera att vi börjar om en ny vända med sortering
                needsSorting = false;
                //Gå igenom alla tal fram till och med de tal som ev. 
                //redan är sorterade (variabeln i)
                for (int j = 0; j < numArr.Length - 1 - i; j++)
                {
                    //Flytta större tal fram i vektorn
                    if (numArr[j] > numArr[j + 1])
                    {
                        //Signalera att vi kommer att behöva fortsätta sortera
                        needsSorting = true;
                        //Byt plats på tal
                        int tmp = numArr[j + 1];
                        numArr[j + 1] = numArr[j];
                        numArr[j] = tmp;
                    }
                }
                //Har vi nu inte behövt sortera några tal så är 
                //needsSorting == false och loop'en kommer att avbrytas

                Console.WriteLine("Din lista sorterad :");
                {
                    foreach (int number in numArr)
                        Console.Write(number + " ");
                }
                Console.WriteLine("\n");
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

            Console.WriteLine("Din lista sorterad för andra gången:");
            {
                foreach (int number in numArr)
                    Console.Write(number + " ");
            }
        }
    }
}