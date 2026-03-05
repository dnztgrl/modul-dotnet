using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace _01_froschkoenig
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            if (System.OperatingSystem.IsWindows())
            {
                path = @"C:\Users\Deniz\Proton Drive\deniztugrul\My files\ITA3-MeineDateien\07. dotNET\02 - RegEx\Aufgaben\Froschkönig Unix Zeilenumbrüche.txt";
            }

            else
            {
                path = @"/Users/deniztugrul/Library/CloudStorage/ProtonDrive-deniztugrul@protonmail.com-folder/ITA3-MeineDateien/07. dotNET/02 - RegEx/Aufgaben/Froschkönig Unix Zeilenumbrüche.txt";
            }
            

            string[] lines = File.ReadAllLines(path);
            
            List<string> a1 = new List<string>();
            List<string> a2 = new List<string>();
            List<string> a3 = new List<string>();
            List<string> a4 = new List<string>();
            List<string> a5 = new List<string>();
            List<string> a6 = new List<string>();
            List<string> a7 = new List<string>();
            List<string> a8 = new List<string>();
            List<string> a9 = new List<string>();
            
            string p1 = "[äöüÄÖÜ]";
            string p2 = @"\b[Dd]er\b";
            string p3 = "^[A-Z]";
            string p4 = @"Frosch|Froschkönig";
            string p5 = @"\.$";
            string p6 = @"ß\b";
            string p7 = @"^$";
            string p8 = @"^[a-zA-ZäöüÄÖÜ]{3}\b";
            string p9 = @"\b([Dd]er|[Dd]ie|[Dd]as)\b";
            
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int nr = i + 1;

                if (Regex.IsMatch(line, p1)) a1.Add($"Zeile {nr}: {line}");
                if (Regex.IsMatch(line, p2)) a2.Add($"Zeile {nr}: {line}");
                if (Regex.IsMatch(line, p3)) a3.Add($"Zeile {nr}: {line}");
                if (Regex.IsMatch(line, p4)) a4.Add($"Zeile {nr}: {line}");
                if (Regex.IsMatch(line, p5)) a5.Add($"Zeile {nr}: {line}");
                if (Regex.IsMatch(line, p6)) a6.Add($"Zeile {nr}: {line}");
                if (Regex.IsMatch(line, p7)) a7.Add($"Zeile {nr}: [LEERE ZEILE]");
                if (Regex.IsMatch(line, p8)) a8.Add($"Zeile {nr}: {line}");
                if (Regex.IsMatch(line, p9)) a9.Add($"Zeile {nr}: {line}");
            }
            
            Console.WriteLine("=== REGEX ANALYSE ERGEBNISSE ===\n");

            Console.WriteLine("--- Aufgabe 1: Umlaute ---");
            foreach (string s in a1) Console.WriteLine(s);
            Console.WriteLine($"Treffer: {a1.Count}\n");

            Console.WriteLine("--- Aufgabe 2: 'der' als einzelnes Wort ---");
            foreach (string s in a2) Console.WriteLine(s);
            Console.WriteLine($"Treffer: {a2.Count}\n");

            Console.WriteLine("--- Aufgabe 3: Beginn mit Großbuchstabe ---");
            foreach (string s in a3) Console.WriteLine(s);
            Console.WriteLine($"Treffer: {a3.Count}\n");

            Console.WriteLine("--- Aufgabe 4: Frosch oder Froschkönig ---");
            foreach (string s in a4) Console.WriteLine(s);
            Console.WriteLine($"Treffer: {a4.Count}\n");

            Console.WriteLine("--- Aufgabe 5: Punkt am Ende ---");
            foreach (string s in a5) Console.WriteLine(s);
            Console.WriteLine($"Treffer: {a5.Count}\n");

            Console.WriteLine("--- Aufgabe 6: Wort endet auf 'ß' ---");
            foreach (string s in a6) Console.WriteLine(s);
            Console.WriteLine($"Treffer: {a6.Count}\n");

            Console.WriteLine("--- Aufgabe 7: Leere Zeilen ---");
            Console.WriteLine($"Anzahl leerer Zeilen im Dokument: {a7.Count}\n");

            Console.WriteLine("--- Aufgabe 8: 3 Buchstaben am Zeilenanfang ---");
            foreach (string s in a8) Console.WriteLine(s);
            Console.WriteLine($"Treffer: {a8.Count}\n");

            Console.WriteLine("--- Aufgabe 9: Bestimmte Artikel (der, die, das) ---");
            foreach (string s in a9) Console.WriteLine(s);
            Console.WriteLine($"Treffer: {a9.Count}\n");

            Console.WriteLine("=================================");
        }
    }
}