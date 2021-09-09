using System;

namespace Uppgifter210906X9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int numArr = new string [num]

            foreach (int number in numArr)
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
                Console.WriteLine("TEST");
                foreach (int number in numArr)
                {
                    Console.WriteLine(number);
                }




            }
        }
    }
}