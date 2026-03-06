using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace aufgabe_collection_worthaeufigkeit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary für die Worthäufigkeit
            Dictionary<string, int> counter = new Dictionary<string, int>();
            
            string path = @"/Users/deniztugrul/Library/CloudStorage/ProtonDrive-deniztugrul@protonmail.com-folder/ITA3-MeineDateien/07. dotNET/02 - RegEx/Aufgaben/Froschkönig Unix Zeilenumbrüche.txt";
            string[] lines = File.ReadAllLines(path);

            // Zeilen durchlaufen
            foreach (string zeile in lines)
            {
                // Alle Wörter in Kleinschreibung umwandeln
                string lowerCase = zeile.ToLower();
                string clean = "";

                // Nur Buchstaben und Leerzeichen beibehalten
                foreach (char c in lowerCase)
                {
                    if (char.IsLetter(c) || char.IsWhiteSpace(c))
                    {
                        clean += c;
                    }
                }
                
                // Sauberen String in einzelne Wörter zerlegen
                string[] words = clean.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Wörter zählen
                foreach (string word in words)
                {
                    // Wort im Dictionary suchen, wenn vorhanden Counter erhöhen
                    if (counter.ContainsKey(word)) 
                        counter[word]++;

                    // Ansonsten Wort mit Startwert 1 hinzufügen
                    else 
                        counter.Add(word, 1);
                }
            }

            // ArrayList für die Sortierung
            ArrayList sortedList = new ArrayList();

            // Wörter aus Dictionary in ArrayList übertragen
            foreach (string key in counter.Keys)
            {
                sortedList.Add(key);
            }
            
            // Sort-Methode des ArrayList aufrufen
            sortedList.Sort();

            // Ausgabe sortierte Liste
            foreach (string key in sortedList)
            {
                Console.WriteLine($"Wort: {key} | Anzahl: {counter[key]}x");
            }
        }
    }
}