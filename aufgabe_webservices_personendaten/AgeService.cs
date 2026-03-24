namespace aufgabe_webservices_personendaten;

public class AgeService
{
    public async Task<string> GetAge(string name)
    {
        string ageURL = $"https://api.agify.io?name={name}";

        HttpClient ageClient = new HttpClient();

        string jsonAge = await ageClient.GetStringAsync(ageURL);

        return jsonAge;
    }
}