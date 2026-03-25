using System;

namespace aufgabe_efcore_schneckenrennen
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchneckenrennenContext())
            {
                context.Database.EnsureCreated();

                var wettbuero = new Wettbuero()
                {
                    Faktor = 500,
                    Rennen = new Rennen()
                    {
                        Name = "Formel Schnecke",
                        MaxTeilnehmer = 7,
                        Rennstrecke = 20
                    }
                };

                wettbuero.Rennen.AddRennschnecke(new Rennschnecke
                {
                    Name = "Speedy",
                    MaxGeschwindigkeit = 5
                });

                wettbuero.Rennen.AddRennschnecke(new Rennschnecke
                {
                    Name = "Turbo",
                    MaxGeschwindigkeit = 3
                });

                wettbuero.Rennen.AddRennschnecke(new Rennschnecke
                {
                    Name = "Flash",
                    MaxGeschwindigkeit = 1
                });

                wettbuero.Rennen.AddRennschnecke(new Rennschnecke
                {
                    Name = "Roadrunner",
                    MaxGeschwindigkeit = 8
                });

                wettbuero.WetteAnnehmen("Speedy", 10, "Tobias");
                wettbuero.WetteAnnehmen("Turbo", 5, "Diana");
                wettbuero.WetteAnnehmen("Flash", 20, "Daniel");
                wettbuero.WetteAnnehmen("Roadrunner", 15, "Nils");

                wettbuero.Rennen.ZeigeTeilnehmer();

                wettbuero.RennAblauf();

                Console.WriteLine(wettbuero.Ausgabe());

                context.Wettbueros.Add(wettbuero);
                context.SaveChanges();
            }
        }
    }
}