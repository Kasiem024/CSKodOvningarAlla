using System;
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
            Console.WriteLine("Hello World!");

            Customer newCustomer;
            newCustomer = new Customer();


        }
    }

    public class Customer
    {
        public string name;
        public string accident;
        public int age;
    }
}
