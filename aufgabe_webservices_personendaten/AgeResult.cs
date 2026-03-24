using System.Text.Json.Serialization;

namespace aufgabe_webservices_personendaten;

public class AgeResult
{
    [JsonPropertyName("age")]
    public int? Age { get; set; }
}