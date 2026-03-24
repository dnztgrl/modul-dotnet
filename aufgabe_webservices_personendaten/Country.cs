using System.Text.Json.Serialization;

namespace aufgabe_webservices_personendaten;

public class Country
{
    [JsonPropertyName("country_id")]
    public string CountryId { get; set; }
    
    [JsonPropertyName("probability")]
    public float Probability { get; set; }
}