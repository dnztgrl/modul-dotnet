using System;
using System.Diagnostics;

namespace Pi_Berechnung
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"{"PI:", -20}{Math.PI}");

            double pi = 0;
            const int anzahlAufrufe = 1000;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            for (int i = 1; i < anzahlAufrufe + 1; i++)
            {
                pi += PI_Berechnung(i, anzahlAufrufe);
            }
            
            sw.Stop();

            Console.WriteLine($"{"Berechneter Wert:", -20}{pi}");

            Console.WriteLine("Dauer {0:N0} Millisekunden", sw.ElapsedMilliseconds);
            
            // ERGEBNIS SERIELL
            // 2500 ms

            // List mit Rückgabewert double
            // Jede Task berechnet einen Teil von PI
            sw.Restart();
            pi = 0;
            List<Task<double>> tasks = new List<Task<double>>();

            for (int i = 1; i <= anzahlAufrufe; i++)
            {
                // Lokale Variable i, damit nicht alle Tasks denselben Wert erhalten
                int aktuellerWert = i;
                Task<double> task = Task.Run(() =>
                {
                    return PI_Berechnung(aktuellerWert, anzahlAufrufe);
                });

                tasks.Add(task);
            }

            // Ergebnisse aller Tasks einsammeln und aufsummieren
            // Task.Result blockiert bis die Task abgeschlossen ist - Verhalten wie Task.Wait
            foreach (var task in tasks)
            {
                pi += task.Result;
            } 
            
            // ERGEBNIS PARALLEL
            // 750ms

            sw.Stop();

            Console.WriteLine($"\n{"PI:", -20}{Math.PI}");
            Console.WriteLine($"{"Berechneter Wert:", -20}{pi}");

            Console.WriteLine("Dauer {0:N0} Millisekunden", sw.ElapsedMilliseconds);
        }

        // Nach John Machin (http://de.wikipedia.org/wiki/John_Machin)
        private static double PI_Berechnung(int startwert, int schrittweite)
        {
            const double durchlaeufe = 1_000_000_000;
            double x, y = 1 / durchlaeufe;
            double summe = 0;
            double pi;

            for (double i = startwert; i <= durchlaeufe; i += schrittweite)
            {
                x = y * (i - 0.5);
                summe += 4.0 / (1 + x * x);
            }

            pi = y * summe;

            return pi;
        }
    }
}