using System.IO;
using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string[] content = File.ReadAllLines("leesdezefile.txt");

        for (int i = 0; i < content.Length; i++)
        {
            Console.WriteLine(content[i]);
        }

        Directory.CreateDirectory("output");
        
            File.WriteAllText("output/mijnnieuwefile.txt", "Hallo");
            File.AppendAllText("output/mijnnieuwefile.txt", "Append");
            

        Console.ReadLine();
    }
}
