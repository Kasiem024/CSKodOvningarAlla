﻿using System;
using System.Collections.Generic;

/*
Vi bygger en enkel applikation för att hantera försäljning av begagnade bilar. 
Funktionerna som behöver stödjas är: 
1/registrera en bil för försäljning
2/redigera uppgifterna för en befintlig bil
3/ta bort en bil som blivit såld
4/visa alla bilar som är till salu
Fundera på domänmodellen, dvs vilka klasser som behövs och vilka properties. Skriv gärna ner det i en textfil, så du har lite "kladdpapper".
Console-applikation med en loop och följande menyalternativ. Använda en switch för detta, se länken nedan.
X = Exit, N=Add Car, E=Edit existing Car, D=Remove Car, S=Show all cars
Hur ska du hantera redigera bil? Användaren bör kunna ange vilken bil som ska redigeras. Hur ska du hantera vad som uppdateras?
Vad händer om användaren ber att få redigera en bil som inte finns?
Samma gäller för att ta bort en bil.
för att ändra en viss bil kan man skriva ut alla bilar och så kan användaren välja vilken av bilarna man vill ändra.
*/

namespace U210913X1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar;
            newCar = new Car();
            List<Car> carList = new List<Car>();

            Console.WriteLine("Welcome to ACME Cars. The company for your car needs!\n");

        start:

            Console.WriteLine("What do you want to do? \n\nX = Exit \nN = Add Car \nE = Edit existing car " +
                "\nD = Remove Car \nS = Show all cars");
            string choice = Console.ReadLine();

            switch (choice.ToUpper())
            {
                case "N":
                    Console.WriteLine("\nYou have chosen to add a new car to the list. \n\nWhat's the color of the car?");
                    newCar.Color = Console.ReadLine();
                    Console.WriteLine("What's the make of the car?");
                    newCar.Make = Console.ReadLine();
                    Console.WriteLine("What's the model of the car?");
                    newCar.Model = Console.ReadLine();
                    Console.WriteLine("What's the price of the car?");
                    newCar.Price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What's the cars license plate?");
                    newCar.LicensePlate = Console.ReadLine();

                    carList.Add(new Car() { Color = newCar.Color, Make = newCar.Make, Model = newCar.Model, Price = newCar.Price, LicensePlate = newCar.LicensePlate });

                    Console.WriteLine($"You have successfully added a {newCar.Color} {newCar.Make} {newCar.Model} worth {newCar.Price}, the license plate is {newCar.LicensePlate}");

                    goto start;

                case "E":
                    Console.WriteLine("\nYou have chosen to edit the information on an existing car.");


                    goto start;

                case "D":
                startRemove:
                    Console.WriteLine("\nYou have chosen to remove an existing car.");

                    int counter = 0;
                    foreach (var car in carList)
                    {
                        Console.WriteLine($"\n{counter} {car.Color} {car.Make} {car.Model} \t Price: {car.Price} \t License plate: {car.LicensePlate}");
                        counter++;
                    }

                    Console.WriteLine("\nChoose which one of those cars you want to remove from the list.\n\nRemember the list starts at 0!");
                    int carRemove = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\nYou have chosen to remove car number {carRemove} from the list.\nAre you sure?" +
                        $"\nWrite Y if you're sure.\nIf you want to change which car to remove write N.\nIf you dont want to remove an existing car write X.");
                    string carRemoveChoice = Console.ReadLine();

                    if (carRemoveChoice.ToUpper() == "Y")
                    {
                        carList.RemoveAt(carRemove);
                    }
                    if (carRemoveChoice.ToUpper() == "N")
                    {
                        goto startRemove;
                    }

                    goto start;

                case "S":

                    Console.WriteLine("\nThis is a list of all the cars:");

                    foreach (var car in carList)
                    {
                        Console.WriteLine($"\n {car.Color} {car.Make} {car.Model} \t Price: {car.Price} \t License plate: {car.LicensePlate}");
                    }

                    goto start;
            }

            if (choice.ToUpper() == "X")
            {
                Console.WriteLine("\nYou have exited the program.");
            }
            else
            {
                Console.WriteLine("\nOpps, seems something went wrong there, try again!" +
                    "\n\n\n");
                goto start;
            }
        }
    }

    public class Car
    {
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public int Price { get; set; }
    }
}