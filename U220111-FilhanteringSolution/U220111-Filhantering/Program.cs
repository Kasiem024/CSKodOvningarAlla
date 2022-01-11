using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
class Uppgift1
{
    public static void Main()
    {

        List<Person> people = new List<Person>();

        people.Add(new Person() { FirstName = "Kasiem", LastName = "Saeed" });
        people.Add(new Person() { FirstName = "Oscar", LastName = "Gustafsson" });
        people.Add(new Person() { FirstName = "Adam", LastName = "Pousette" });

        foreach (var item in people)
        {
            Console.WriteLine($"{item.FirstName} {item.LastName}");
        }

        Console.WriteLine("Tryck enter för att spara filen");
        Console.ReadLine();

        string path = ".\\data.bin";

        FileStream fs = new FileStream("data.bin", FileMode.Create);

        // Construct a BinaryFormatter and use it to serialize the data to the stream.
        BinaryFormatter formatter = new BinaryFormatter();
        try
        {
            formatter.Serialize(fs, people);
        }
        catch (SerializationException e)
        {
            Console.WriteLine("Failed to serialize. Reason: " + e.Message);
            throw;
        }
        finally
        {
            fs.Close();
        }
    }

    private static void AddText(FileStream fs, string value)
    {
        byte[] info = new UTF8Encoding(true).GetBytes(value);
        fs.Write(info, 0, info.Length);
    }
}

[Serializable]
class Person
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
}