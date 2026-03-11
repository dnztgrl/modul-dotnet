using System;
using System.IO;
using System.Net;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string pathToWatch = @"/Users/deniztugrul/RiderProjects/modul-dotnet/aufgabe_dateien_filesystemwatcher/Lookup"; 
        
        FolderWatcher watcher = new FolderWatcher(pathToWatch);

        Console.WriteLine($"🔍 Überwachung läuft in: {pathToWatch}");
        Console.WriteLine("⌨️ Drücke ENTER, um das Programm zu beenden...");
        
        Console.ReadLine();
    }
}