using System;
//Låt användaren mata in en mening.
//Skriv ut varje unik bokstav på en egen rad, och ange hur ofta den förekommer

namespace U210906X4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Techie Delight";
            char ch = 'e';

            int freq = str.Split(ch).Length - 1;
            Console.WriteLine(freq);

            string str = "Techie Delight";
            char ch = 'e';

            int freq = 0;
            foreach (char c in str)
            {
                if (c == ch)
                {
                    freq++;
                }
            }

            Console.WriteLine(freq);
        }
    }
}
