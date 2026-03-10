namespace aufgabe_events_beobachteramfluss;

class Program
{
    static void Main(string[] args)
    {
        // Broadcaster Rhein und die Objekte für die Subscriber
        Fluss rhein = new Fluss("Rhein");
        Stadt duesseldorf = new Stadt("Düsseldorf");
        Stadt koeln = new Stadt("Köln");
        Schiff rheingold = new Schiff("Rheingold");
        Schiff lorelei = new Schiff("Lorelei");
        
        // Broadcaster Donau und die Objekte für die Subscriber
        Fluss donau = new Fluss("Donau");
        Stadt ulm = new Stadt("Ulm");
        Schiff xaver = new Schiff("Xaver");
        Schiff franz = new Schiff("Franz");
        Klaerwerk strauß1 = new Klaerwerk("Strauß 1");
        
        // Rhein-Subscriber bei den Events anmelden
        rhein.WasserstandUnter250 += rheingold.AusgabeFahrtstop;
        rhein.WasserstandUnter250 += lorelei.AusgabeFahrtstop;
        rhein.WasserstandUeber8000 += rheingold.AusgabeFahrtstop;
        rhein.WasserstandUeber8000 += lorelei.AusgabeFahrtstop;
        rhein.WasserstandUeber8200 += duesseldorf.AusgabeSchutzwand;
        rhein.WasserstandUeber8200 += koeln.AusgabeSchutzwand;
        
        // Donau-Subscriber bei den Events anmelden
        donau.WasserstandUnter250 += xaver.AusgabeFahrtstop;
        donau.WasserstandUnter250 += franz.AusgabeFahrtstop;
        donau.WasserstandUeber8000 += xaver.AusgabeFahrtstop;
        donau.WasserstandUeber8000 += franz.AusgabeFahrtstop;
        donau.WasserstandUeber8200 += ulm.AusgabeSchutzwand;
        donau.WasserstandUeber8000 += strauß1.AusgabeEinleitungStop;
        donau.WasserstandUnter3000 += strauß1.AusgabeEinleitungSteigern;

        // Normaler Wasserstand - Klärwerke an der Donau steigern ihre Einleitung (Wasserstand < 3000), sonst passiert nichts
        Console.WriteLine("\n===== TEST | NORMALER WASSERSTAND | KLÄRWERK AN DER DONAU STEIGERT EINLEITUNG =====");
        rhein.Wasserstand = 1000;
        donau.Wasserstand = 1000;
        
        // Wasserstand < 250 - Klärwerke steigern ihre Einleitung & Schiffe halten an
        Console.WriteLine("===== TEST | WASSERSTAND < 250 | SCHIFFE HALTEN AN =====");
        rhein.Wasserstand = 150;
        donau.Wasserstand = 150;
        
        // Wasserstand > 8200 - Schiffe halten an, Klärwerke stoppen ihre Einleitungen, Städte errichten eine Wasserschutzwand
        Console.WriteLine("===== TEST | WASSERSTAND > 8200 | KLÄRWERK AN DER DONAU STOPPT EINLEITUNG, STÄDTE ERRICHTEN WASSERSCHUTZWAND & SCHIFFE HALTEN AN =====");
        rhein.Wasserstand = 8300;
        donau.Wasserstand = 8300;
    }
}