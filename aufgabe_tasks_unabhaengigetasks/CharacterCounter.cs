using System.Text;
using System.Threading;

namespace aufgabe_tasks_unabhaengigetasks;

public class CharacterCounter
{
    public void BerechneBuchstabenHaeufigkeit(string dateipfad)
    {
        Thread.Sleep(2000);
        
        string inhaltDatei = File.ReadAllText(dateipfad);
        
        // Dictionary zur Speicherung der Häufigkeit
        Dictionary<char, int> buchstabenZaehler = new Dictionary<char, int>();

        
        foreach (char c in inhaltDatei)
        {
            if (char.IsLetter(c))
            {
                char buchstabe = char.ToLower(c);
                if (buchstabenZaehler.ContainsKey(buchstabe))
                {
                    buchstabenZaehler[buchstabe]++;
                }

                else
                {
                    buchstabenZaehler.Add(buchstabe, 1);
                }
            }   
        }

        // StringBuilder zum Sammeln der Ausgabe für die Datei
        StringBuilder sb = new StringBuilder();

        Console.WriteLine($"Start: {dateipfad}");
        foreach (var eintrag in buchstabenZaehler)
        {
            // Fügt Zeile zum StringBuilder hinzu
            sb.AppendLine($"{eintrag.Key}: {eintrag.Value}");
            // Gibt die gleiche Information in der Konsole aus
            Console.WriteLine($"{eintrag.Key}: {eintrag.Value}");
        }
        Console.WriteLine($"Ende: {dateipfad} ");

        // Erstellt neue Datei mit der Endung .freq
        string neueDatei = Path.ChangeExtension(dateipfad, ".freq");
        // Schreibt den gesamten Inhalt des StringBuilder in die neue Datei
        File.WriteAllText(neueDatei, sb.ToString());
    }
}