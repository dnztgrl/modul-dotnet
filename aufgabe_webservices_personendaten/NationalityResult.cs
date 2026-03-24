using System.Text.Json.Serialization;

namespace aufgabe_webservices_personendaten;

public class NationalityResult
{
    [JsonPropertyName("country")]
    public List<Country> Countries { get; set; }
}