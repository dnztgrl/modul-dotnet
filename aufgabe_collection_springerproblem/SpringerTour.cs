namespace aufgabe_collection_springerproblem;

public class SpringerTour
{
    private int[,] _spielbrett = new int[8, 8];
    private int _zugNummer = 0;
    private int _x;
    private int _y;

    public void SetzeStartPosition()
    {
        bool eingabeKorrekt = false;    
        do
        {
            Console.WriteLine("\nGeben Sie eine Startposition für den Springer ein: ");
            Console.WriteLine("Spalte A-H: ");
            char spalte = char.ToUpper(Console.ReadLine()[0]);

            if (spalte < 'A' || spalte > 'H')
            {
                Console.WriteLine("\nUngültige Eingabe\n");
                continue;
            } 
            
            _x = spalte - 'A';
        
            Console.WriteLine("\nZeile 1-8: ");
            _y = Convert.ToInt32(Console.ReadLine()) - 1;

            if (_y < 0 || _y > 7)
            {
                Console.WriteLine("\nUngültige Eingabe\n");
                continue;
            }
            
            _zugNummer = 1;
            _spielbrett[_x, _y] = _zugNummer;
            
            eingabeKorrekt = true;
            
        } while (!eingabeKorrekt);
    }

    private List<int[]> MoeglicheZuege(int x, int y)
    {
        List<int[]> gueltigeZuege = new List<int[]>();

        // Alle 8 möglichen Springerbewegungen als Koordinatenpaare in einer Liste
        List<int[]> springerZuege = new List<int[]>
        {
            new int[] { -2, -1 },
            new int[] { -2, 1 },
            new int[] { -1, -2 },
            new int[] { -1, 2 },
            new int[] { 1, -2 },
            new int[] { 1, 2 },
            new int[] { 2, -1 },
            new int[] { 2, 1 }
        };
        
        for(int i = 0; i < springerZuege.Count; i++)
        {
            int neueXPos = x + springerZuege[i][0];
            int neueYPos = y + springerZuege[i][1];

            // Prüft, ob das Feld auf dem Spielfeld ist und noch nicht besucht wurde
            if (neueXPos >= 0 && neueXPos < 8 && neueYPos < 8 && neueYPos >= 0)
            {
                if(_spielbrett[neueXPos, neueYPos] == 0) 
                    gueltigeZuege.Add(new int[]  { neueXPos, neueYPos });
            }
        }
        
        return gueltigeZuege;
    }

    public void StarteSpringerTour()
    {
        while (_zugNummer < 64)
        {
            // Mögliche Züge von der aktuellen Position berechnen
            List<int[]> ergebnis = MoeglicheZuege(_x, _y);

            int[] besterZug = null;
            int kleinsteAnzahlNachfolger = int.MaxValue;

            // Für jeden möglichen Zug die Anzahl der Nachfolger berechnen
            for (int i = 0; i < ergebnis.Count; i++)
            {
                int anzahlNachfolger = MoeglicheZuege(ergebnis[i][0], ergebnis[i][1]).Count;
                
                // Zug mit wenigsten Nachfolgern merken
                if (anzahlNachfolger < kleinsteAnzahlNachfolger)
                {
                    kleinsteAnzahlNachfolger = anzahlNachfolger;
                    besterZug = ergebnis[i]; 
                }
            }
            
            // Zum besten Feld springen und Spielbrett aktualisieren
            _x = besterZug[0];
            _y = besterZug[1];
            _zugNummer++;
            _spielbrett[_x, _y] = _zugNummer;
        }
    }

    public void ZeigeSpielbrett()
    {
        Console.WriteLine();
        string rahmen = "+----+----+----+----+----+----+----+----+";
        
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(rahmen);
            Console.Write("|");
            for (int j = 0; j < 8; j++)
            {
                Console.Write($" {_spielbrett[i, j]:D2} ");
                Console.Write("|");
            }
            Console.WriteLine();
        }
        Console.WriteLine(rahmen);
    }
}