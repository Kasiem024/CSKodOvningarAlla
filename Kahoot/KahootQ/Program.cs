using System;

namespace KahootQ
{
    class Program
    {
        public static void Main()
        {
            int i = 242424;
            i.ToString();
            string answer = "Du är förvirrad som fan";
            second();
        }
        public void first()
        {
            Console.WriteLine("second method");
        }
        public static void second()
        {
            Console.WriteLine("first method");
        }
        public void First()
        {
            string first = "second method";
            Console.WriteLine(first);
            Console.WriteLine("third method");
        }
        public static void Second()
        {
            Console.WriteLine("fourth method");
        }
    }
}