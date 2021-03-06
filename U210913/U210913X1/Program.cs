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
*/

namespace U210913X1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar;
            newCar = new Car();//Det här är faktistk typ onödigt men jag är lat så det får bli.
            List<Car> carList = new List<Car>();//Skapar listan carList

            Console.WriteLine("Welcome to ACME Cars. The company for your car needs!\n");

        start://Har det innan man väljer vad man vill gör för att skriva mindre kod och så att en loop skapas.

            Console.WriteLine("\nWhat do you want to do? \n\nX = Exit \nN = Add Car \nE = Edit existing car " +
                "\nD = Remove Car \nS = Show all cars");
            string choice = Console.ReadLine();

            if (carList.Count == 0 && choice.ToUpper() != "N" && choice.ToUpper() != "X")//Ifall listan är tom ska man endast kunna avsluta programmet elelr lägga till en ny bil.
            {
                Console.WriteLine("\nThere are no cars on the list, you must first add a car to access this function.");
                goto start;
            }

            switch (choice.ToUpper())//Om användaren matar in en liten bokstav i choice konverteras den till en stor.
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

                    Console.WriteLine($"\nYou have successfully added a {newCar.Color} {newCar.Make} {newCar.Model} worth {newCar.Price} kr, the license plate is {newCar.LicensePlate}");

                    goto start;//Behöver inte en break för att programmet går tillbaka till start hela tiden vilket skapar en loop.

                case "E":
                    startEdit://Ifall användaren gör något fel under denna case kommer den tillbaka hit.
                        Console.WriteLine("\nYou have chosen to edit the information on an existing car.");

                        int counter = 0;//En counter för att hjälpa användaren välja vilken bil. Eftersom listan börjar på 0 kan en okunnig ha problem.
                        foreach (var car in carList)
                        {
                            Console.WriteLine($"\nNumber: {counter} {car.Color} {car.Make} {car.Model} Price: {car.Price} kr License plate: {car.LicensePlate}");
                            counter++;
                        }
                        //Skriver ut listan för att låta användaren välja.
                        Console.WriteLine("\nChoose which one of those cars you want to edit.");
                        int carNum = Convert.ToInt32(Console.ReadLine());

                        if (carNum >= carList.Count)//Ifall användaren väljer en bil som inte existerar.
                        {
                            Console.WriteLine("\nYou have not chosen a car from the list, try again!");
                            goto startEdit;
                        }

                        Console.WriteLine($"\nYou have chosen to edit car number {carNum}.\n\nAre you sure?" +
                            $"\n\nWrite Y if you're sure.\n\nIf you want to change which car to remove write N.\n\nIf you don't want to edit an existing car write X.");
                        string carEditChoice = Console.ReadLine();//Ifall användaren valde fel bil eller ändrade sig.

                        if (carEditChoice.ToUpper() == "Y")
                        {
                            Console.WriteLine("\nChoose what part of the car you want to edit.\n\nC = Color\nMA = Make\nMO = Model" +
                                "\nP = Price\nLP = License plate");
                            string carEdit = Console.ReadLine();

                            switch (carEdit.ToUpper())//Den här delen av koden känns som den kan efektiveras men vet inte hur i nuläget.
                            {
                                case "C":
                                    Console.WriteLine($"\nThe color of the car is currently {carList[carNum].Color}. What do you want to change it to?");
                                    carList[carNum].Color = Console.ReadLine();

                                    Console.WriteLine($"\nThe color of the car is currently {carList[carNum].Color}.");

                                    break;

                                case "MA":
                                    Console.WriteLine($"\nThe make of the car is currently {carList[carNum].Make}. What do you want to change it to?");
                                    carList[carNum].Make = Console.ReadLine();

                                    Console.WriteLine($"\nThe make of the car is currently {carList[carNum].Make}.");

                                    break;

                                case "MO":
                                    Console.WriteLine($"\nThe model of the car is currently {carList[carNum].Model}. What do you want to change it to?");
                                    carList[carNum].Model = Console.ReadLine();

                                    Console.WriteLine($"\nThe make of the car is currently {carList[carNum].Model}.");

                                    break;

                                case "P":
                                    Console.WriteLine($"\nThe price of the car is currently {carList[carNum].Price} kr. What do you want to change it to?");
                                    carList[carNum].Price = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine($"\nThe make of the car is currently {carList[carNum].Price} kr.");

                                    break;

                                case "LP":
                                    Console.WriteLine($"\nThe license plate of the car is currently {carList[carNum].LicensePlate}. What do you want to change it to?");
                                    carList[carNum].LicensePlate = Console.ReadLine();

                                    Console.WriteLine($"\nThe make of the car is currently {carList[carNum].LicensePlate}.");

                                    break;
                            }
                        }
                        if (carEditChoice.ToUpper() == "N")
                        {
                            goto startEdit;
                        }
                    goto start;

                case "D":
                    startRemove:
                        Console.WriteLine("\nYou have chosen to remove an existing car.");

                        counter = 0;
                        foreach (var car in carList)
                        {
                            Console.WriteLine($"\nNumber: {counter} {car.Color} {car.Make} {car.Model} Price: {car.Price} kr License plate: {car.LicensePlate}");
                            counter++;
                        }

                        Console.WriteLine("\nChoose which one of those cars you want to remove from the list.");
                        carNum = Convert.ToInt32(Console.ReadLine());

                        if (carNum >= carList.Count)
                        {
                            Console.WriteLine("\n\nYou have not chosen a car from the list, try again!");
                            goto startRemove;
                        }

                        Console.WriteLine($"\nYou have chosen to remove car number {carNum} from the list.\n\nAre you sure?" +
                            $"\n\nWrite Y if you're sure.\n\nIf you want to change which car to remove write N.\n\nIf you don't want to remove an existing car write X.");
                        string carRemoveChoice = Console.ReadLine();

                        if (carRemoveChoice.ToUpper() == "Y")
                        {
                            carList.RemoveAt(carNum);
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
                            Console.WriteLine($"\nNumber: {car.Color} {car.Make} {car.Model} Price: {car.Price} kr License plate: {car.LicensePlate}");
                        }

                    goto start;

                case "X":
                    Console.WriteLine("\nYou have exited the program.");
                    break;

                default:
                    Console.WriteLine("\nOpps, seems something went wrong there, try again!" +
                        "\n\n\n");
                    goto start;
            }
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