namespace aufgabe_delegates_logger;

delegate void LoggerHandler(string text);

class Program
{
    static void Main(string[] args)
    {
        // Logger-Objekt mit Pfad zur Datei
        Logger l = new Logger(@"");

        LoggerHandler lh = l.Write;
        
        LoggerHandler anonym = delegate(string text)
        {
            string gross = new string(text.ToUpper());
            Console.WriteLine(gross);
        };
        
        lh += anonym;
        
        // Schreibt Text in die Datei und gibt ihn in Großbuchstaben auf der Konsole aus
        lh("A long time ago in a galaxy far, far away...");
        lh("It is a period of civil war");
        lh("Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire.");
        
        l.Close();
    }
}