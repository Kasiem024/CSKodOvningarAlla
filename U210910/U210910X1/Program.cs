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
            List<Customer> customerList = new List<Customer>();//Skapar listan customerList.

        tryAgain://Ifall vad som skrivs in i choice inte är 1-4 kommer programmet tillbaka hit.

            Console.WriteLine("Vad vill du göra? \n\n1-Skapa ny kund \n2-Visa antal kunder \n3-Visa lista över alla kunder \n4-Avsluta");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice < 4)//Switch finns inuti while så att användaren kan hoppa från case till case i programmet.
            {
                switch (choice)//Beroende på vad choice är just nu kommer programmet hoppa till en case.
                {
                    case 1:
                        Console.WriteLine("\nDu har valt att skapa en ny kund. \n\nVad heter kunden?");
                        newCustomer.name = Console.ReadLine();

                        Console.WriteLine("Hur gammal är kunden?");
                        newCustomer.age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Vad är kundens telefonnummer?");
                        newCustomer.phoneNumber = Convert.ToInt32(Console.ReadLine());

                        customerList.Add(new Customer() { name = newCustomer.name, age = newCustomer.age, phoneNumber = newCustomer.phoneNumber });//Här läggs till vad som användaren skrev i listan.

                        Console.WriteLine("\nDu har nu skapat en ny kund. \nVad vill du göra? \n1-Skapa ny kund \n2-Visa antal kunder \n3-Visa lista över alla kunder \n4-Avsluta\n");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine($"\nAntalet kunder är: {customerList.Count}");//Räknar antalet element i listan.

                        Console.WriteLine("\nVad vill du göra? \n1-Skapa ny kund \n2-Visa antal kunder \n3-Visa lista över alla kunder \n4-Avsluta\n");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("\nDetta är listan över alla kunder:\n");

                        foreach (var customer in customerList)
                        {
                            Console.WriteLine($"\nNamn: {customer.name}\nTelefonnummer: {customer.phoneNumber}\nÅlder:{customer.age}");
                        }

                        Console.WriteLine("\nVad vill du göra? \n1-Skapa ny kund \n2-Visa antal kunder \n3-Visa lista över alla kunder \n4-Avsluta\n");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            if (choice == 4)
            {
                Console.WriteLine("\nProgrammet avslutas ");
            }
            else
            {
                Console.WriteLine("\nOj något gick snett där, försök igen!");
                goto tryAgain;//Hoppar tillbaka i koden så att programmet startar om.
            }
        }

        public class Customer//Klassen Customer skapas, det är en datatyp nu likt till string, int m.m.
        {
            public string name;
            public int phoneNumber;
            public int age;
        }
    }
}
