using System.Text.Json;
using System.IO;

namespace aufgabe_json_fizzbuzz;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Geben Sie eine json-Datei an. Lassen Sie das Feld leer für eine normale Zahlenausgabe.");
        string jsonFileInput = Console.ReadLine();
        Console.WriteLine();
        
        if (jsonFileInput == "")
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
        }

        else if (File.Exists(jsonFileInput))
        {
            string json = File.ReadAllText(jsonFileInput);
            List<Rule> rules = JsonSerializer.Deserialize<List<Rule>>(json);

            for (int i = 1; i < 101; i++)
            {
                string result = "";
                
                foreach (Rule rule in rules)
                {
                    if (i % rule.Value == 0)
                    {
                        result += rule.Output;
                    }
                }

                if (string.IsNullOrEmpty(result))
                    Console.WriteLine(i);

                else
                    Console.WriteLine(result);
            }
        }
        else
            Console.WriteLine("\nDie angegebene Datei existiert nicht.");
    }
}