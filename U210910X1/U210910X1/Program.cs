using System;
using System.Collections.Generic;

/*
Vi vill bygga ett program för att hantera lite enkel CRM - customer relationship management, dvs en lista över kunder. 
CRM systemet ska användas av vår Biluthyrare. Så fundera på domänen och vilka klasser som behövs och vilka egenskaper. 
Skriv gärna ner det i ett textdokument i projektet, det blir som ett kladdpapper för dig.
Skapa ny kund (användaren ska kunna mata in uppgifter om en ny kund)
Visa hur många kunder som finns i systemet
Visa en lista över alla kunderna
Begränsa antalet egenskaper för en Kund, vi övar bara så säg ca 3 egenskaper (du får givetvis skriva fler, gör det gärna i kladdpappret, men implementer/koda endast 3 st)
Fundera över gränssnittet, hur kan du låta programmet hantera att jag vill göra något av de tre funktionerna? 
Någon typ av enkel meny (1-Skapa ny kund, 2-Visa antal kunder, 3-Visa lista över alla kunder, 4-Avsluta
*/

namespace U210910X1
{
    class Program
    {
        static void Main(string[] args)
        {


            Customer newCustomer;
            newCustomer = new Customer();
            List<Customer> customerList = new List<Customer>();



            Console.WriteLine("Vad vill du göra? \n1-Skapa ny kund \n2-Visa antal kunder \n3-Visa lista över alla kunder \n4-Avsluta");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice < 4)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Du har valt att skapa en ny kund. \nVad heter kunden?");
                        newCustomer.name = Console.ReadLine();
                        Console.WriteLine("Hur gammal är kunden?");
                        newCustomer.age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Vad är kundens telefonnummer?");
                        newCustomer.phoneNumber = Convert.ToInt32(Console.ReadLine());

                        customerList.Add(new Customer() { name = newCustomer.name, age = newCustomer.age, phoneNumber = newCustomer.phoneNumber });


                        Console.WriteLine("Vad vill du göra? \n1-Skapa ny kund \n2-Visa antal kunder \n3-Visa lista över alla kunder \n4-Avsluta");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine($"Antalet kunder är: {customerList.Count}");

                        Console.WriteLine("Vad vill du göra? \n1-Skapa ny kund \n2-Visa antal kunder \n3-Visa lista över alla kunder \n4-Avsluta");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Detta är listan över alla kunder:");

                        foreach (var customer in customerList)
                        {
                            Console.WriteLine($"{customer.name}\n {customer.phoneNumber}\n {customer.age}");
                        }

                        Console.WriteLine("Vad vill du göra? \n1-Skapa ny kund \n2-Visa antal kunder \n3-Visa lista över alla kunder \n4-Avsluta");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Programmet avslutas ");
                        break;
                }
            }
        }
    }

    public class Customer
    {
        public string name;
        public int phoneNumber;
        public int age;
    }
}
