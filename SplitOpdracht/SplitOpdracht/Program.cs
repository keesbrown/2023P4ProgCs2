using System.IO;
using System;
using System.Net.Http;

public class Program
{
    public static void Main()
    {
        string content = File.ReadAllText(@"C:\ma\prog\c#\SplitOpdracht\SplitOpdracht\stringsplit.txt");
        string[] keyvalue = content.Split(":");
        foreach(string key in keyvalue)
        {
            Console.WriteLine(key);
        }

        string[] cijfersPerVak = keyvalue[1].Split(",");
        foreach (string cijfer in cijfersPerVak)
        {
            if (!(cijfer == ""))
            {
                Console.WriteLine(cijfer.Replace(" ", ""));
            }
            
        }
    }
}
