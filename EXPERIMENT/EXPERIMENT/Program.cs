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



        }
    }

    public class Car
    {
        public string color;
        public string make;
        public string model;


    }
}
