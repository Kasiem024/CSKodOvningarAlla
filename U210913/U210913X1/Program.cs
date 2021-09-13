using System;
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
            List<Car> carList = new List<Car>();

        tryAgain:

            Console.WriteLine("What do you want to do? \nX = Exit \nN = Add Car \nE = Edit existing car " +
                "\nD = Remove Car \nS = Show all cars \nOBS You need to write your choice in capital letters");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "N":
                    Console.WriteLine("TEST");

                    Console.WriteLine("What do you want to do? \nX = Exit \nN = Add Car \nE = Edit existing car " +
                        "\nD = Remove Car \nS = Show all cars \nOBS You need to write your choice in capital letters");
                    choice = Console.ReadLine();
                    break;

                case "E":
                    Console.WriteLine("What do you want to do? \nX = Exit \nN = Add Car \nE = Edit existing car " +
                        "\nD = Remove Car \nS = Show all cars \nOBS You need to write your choice in capital letters");
                    choice = Console.ReadLine();
                    break;

                case "D":
                    Console.WriteLine("What do you want to do? \nX = Exit \nN = Add Car \nE = Edit existing car " +
                        "\nD = Remove Car \nS = Show all cars \nOBS You need to write your choice in capital letters");
                    choice = Console.ReadLine();
                    break;

                case "S":
                    Console.WriteLine("What do you want to do? \nX = Exit \nN = Add Car \nE = Edit existing car " +
                        "\nD = Remove Car \nS = Show all cars \nOBS You need to write your choice in capital letters");
                    choice = Console.ReadLine();
                    break;

            }

            if (choice == "X")
            {
                Console.WriteLine("You have exited the program");
            }
            else
            {
                Console.WriteLine("Opps, seems something went wrong there, try again!");
                goto tryAgain;
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