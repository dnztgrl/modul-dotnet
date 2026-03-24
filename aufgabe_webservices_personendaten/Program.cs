using System.Text.Json;

namespace aufgabe_webservices_personendaten;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Geben Sie bitte einen Namen ein: ");
        string nameUserInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nameUserInput) || !nameUserInput.All(c => char.IsLetter(c) || c == ' ' || c == '-'))
        {
            Console.WriteLine("Fehler bei der Eingabe!");
            return;
        }

        GenderService gs1 = new GenderService();
        var genderAusgabeInJson = gs1.GetGender(nameUserInput).Result;

        AgeService as1 = new AgeService();
        var ageAusgabeInJson = as1.GetAge(nameUserInput).Result;

        NationalityService ns1 = new NationalityService();
        var nationalityAusgabeInJson = ns1.GetNationality(nameUserInput).Result;
        
        GenderResult gr1 = JsonSerializer.Deserialize<GenderResult>(genderAusgabeInJson);
        AgeResult ar1 = JsonSerializer.Deserialize<AgeResult>(ageAusgabeInJson);
        NationalityResult nr1 = JsonSerializer.Deserialize<NationalityResult>(nationalityAusgabeInJson);
        

        if (gr1 == null || ar1 == null || nr1 == null)
        {
            Console.WriteLine("Fehler beim Verarbeiten der Daten!");
            return;
        }
        
        if (gr1.Probability < 0.3)
        {
            Console.WriteLine("Hinweis: Der Name scheint ungewöhnlich zu sein (niedrige Trefferwahrscheinlichkeit)");
            return;
        }

        Console.WriteLine($"\n{"Name:",-10} {nameUserInput,-10}");
        Console.WriteLine($"{"Alter:",-10} {ar1.Age,-10}");
        Console.WriteLine($"{"Gender:",-10} {gr1.Gender,-10} Probability: {gr1.Probability:P2}");
        
        if (nr1.Countries != null && nr1.Countries.Count != 0)
        {
            foreach (var country in nr1.Countries)
            {
                Console.WriteLine($"{"Country:",-10} {country.CountryId,-10} {"Probability:",-10} {country.Probability:P2}");
            }
        }

        else
        {
            Console.WriteLine("Keine Länder gefunden");
        }
    }
}