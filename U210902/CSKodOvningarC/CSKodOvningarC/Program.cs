using System;

namespace CSKodOvningarC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett palindrom: ");
            string pal = Console.ReadLine();
            char[] arr = pal.ToCharArray();
            Array.Reverse(arr);
            pal = new string(arr);
            Console.WriteLine(pal);
        }
    }
}
