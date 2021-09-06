using System;

namespace CSKodOvningarD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett tal mellan 1-10: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1 && num <= 10)
            {
                int[] arr = new int[num];

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Mata in ett tal: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                int sum = 0;
                foreach (int item in arr)
                {
                    sum += item;
                }

                Console.WriteLine("Summan av alla talen du matade in är: " + sum);

                Array.Sort(arr);
                Console.WriteLine("Det minsta talet du matade in är: " + arr[0] + ", och det största talet är: " + arr[num - 1]);

                if (num % 2 == 0)
                {
                    double even1 = arr[((num - 1) / 2) + 1];
                    double even2 = arr[num / 2];
                    double evenres = (even1 + even2) / 2;
                    Console.WriteLine("Medianen av talen du matade in är: " + evenres);
                }
                else
                {
                    int odd = arr.Length / 2;
                    Console.WriteLine("Medianen av talen du matade in är: " + arr[odd]);
                }
            }
            else
            {
                Console.WriteLine("Du har matat in ett felaktigt tal, starta om programmet.");
            }
        }
    }
}