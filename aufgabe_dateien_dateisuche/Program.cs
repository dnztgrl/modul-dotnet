using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        string targetFileName = "log.txt";
        string searchPath = @"/Users/deniztugrul/RiderProjects/modul-dotnet/aufgabe_dateien_dateisuche";
        string searchPattern = "*.txt";

        List<string> aList = new List<string>(); 

        while (userInput != ".")
        {
            Console.WriteLine("\nGeben Sie bitte einen Text ein: ");
            userInput = Console.ReadLine();
            if (userInput == ".")
            {
                break;
            }
            else
            {
                Console.WriteLine($"\n{DateTime.Now} | {userInput}");
                string userInputWithTime = $"{DateTime.Now} | {userInput}";
                aList.Add(userInputWithTime);
            }
        }

        DirectoryInfo aDirectory = new DirectoryInfo(searchPath);
        FileInfo[] files = aDirectory.GetFiles(searchPattern, SearchOption.AllDirectories);
        FileInfo foundFile = null;

        try
        {
            foreach (FileInfo f in files)
            {
                if (f.Name == targetFileName)
                {
                    foundFile = f;
                    break;
                }
            }

            if (foundFile != null)
            {
                using (StreamWriter sw = new StreamWriter(foundFile.FullName, true))
                {
                    foreach (string l in aList)
                    {
                        sw.WriteLine(l);
                    }
                }
            }

            else
            {
                Console.WriteLine("Datei nicht gefunden!");
            }
        }

        catch (Exception e)
        {
            Console.WriteLine($"Da ist etwas schiefgelaufen! {e.Message}");
        }
    }
}