namespace aufgabe_webservices_personendaten;

public class GenderService
{
    public async Task<string> GetGender(string name)
    {
        string genderURL = $"https://api.genderize.io?name={name}";

        HttpClient genderClient = new HttpClient();

        string jsonGender = await genderClient.GetStringAsync(genderURL);

        return jsonGender;
    }
}