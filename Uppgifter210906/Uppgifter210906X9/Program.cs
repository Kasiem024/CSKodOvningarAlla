using System;

namespace Uppgifter210906X9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool needsSorting = true;
            //Gör en loop för varje tal som skall sorteras, avbryt om talen är sorterade
            for (int i = 0; i < data.Length - 1 && needsSorting; i++)
            {
                //Signalera att vi börjar om en ny vända med sortering
                needsSorting = false;
                //Gå igenom alla tal fram till och med de tal som ev. 
                //redan är sorterade (variabeln i)
                for (int j = 0; j < data.Length - 1 - i; j++)
                {
                    //Flytta större tal fram i vektorn
                    if (data[j] > data[j + 1])
                    {
                        //Signalera att vi kommer att behöva fortsätta sortera
                        needsSorting = true;
                        //Byt plats på tal
                        int tmp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = tmp;
                    }
                }
                //Har vi nu inte behövt sortera några tal så är 
                //needsSorting == false och loop'en kommer att avbrytas

                int[] arr = { 78, 55, 45, 98, 13 };
                int temp;
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    for (int i = 0; i <= arr.Length - 2; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            temp = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
                Console.WriteLine("Sorted:");
                foreach (int p in arr)
                    Console.Write(p + " ");
                Console.Read();
            }
        }
    }
}