using System;
using System.IO;
class Uppgift1
{
    public static void Main()
    {
        Console.WriteLine("Vad heter du?");
        string name = Console.ReadLine();

        Console.WriteLine("Tryck enter för att läsa upp filen");
        Console.ReadLine();

        string path = ".\\hello.txt";

        if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(name);
            }
        }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}