using System.IO;
using System;

public class Program
{
    public static void Main()
    {
        DirectoryInfo dir = new DirectoryInfo(@"C:\ma\prog\c#\FileDirOpdracht");
        PrintFilesAndDirectories(dir);
    }

    public static void PrintFilesAndDirectories(DirectoryInfo directory)
    {
        FileInfo[] files = directory.GetFiles();
        DirectoryInfo[] Folders = directory.GetDirectories();

        foreach (FileInfo file in files)
        {
            Console.WriteLine(file.Name);
        }

        foreach (DirectoryInfo Folder in Folders)
        {
            Console.WriteLine(Folder.FullName);
            PrintFilesAndDirectories(Folder);
        }
    }
}

