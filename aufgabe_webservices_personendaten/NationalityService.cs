namespace aufgabe_webservices_personendaten;

public class NationalityService
{
    public async Task<string> GetNationality(string name)
    {
        string nationalityURL = $"https://api.nationalize.io?name={name}";

        HttpClient nationalityClient = new HttpClient();

        string jsonAge = await nationalityClient.GetStringAsync(nationalityURL);

        return jsonAge;
    }
}