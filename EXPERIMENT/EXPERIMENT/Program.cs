using System;
using System.Collections.Generic;

namespace EXPERIMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car myCar;
            myCar = new Car();
            myCar.color = "red";
            myCar.make = "Volvo";
            myCar.model = "V70";

            List<Car> myCars = new List<Car>();
            myCars.Add(myCar);

            Console.WriteLine("TEST");
            Console.WriteLine(myCars.Contains(myCar));

            foreach (var item in myCars)
            {
                Console.WriteLine($"{item.color} och {item.make} och {item.model}.");
            }

        }
    }

    public class Car
    {
        public string color;
        public string make;
        public string model;
    }
}
