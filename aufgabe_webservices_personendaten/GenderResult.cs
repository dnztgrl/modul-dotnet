using System.Text.Json.Serialization;

namespace aufgabe_webservices_personendaten;

public class GenderResult
{
    [JsonPropertyName("gender")]
    public string Gender { get; set; }
    
    [JsonPropertyName("probability")]
    public float Probability { get; set; }
}