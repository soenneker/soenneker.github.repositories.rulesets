using System.Text.Json.Serialization;

public class HrefObj
{
    [JsonPropertyName("href")]
    public string? Href { get; set; }
}