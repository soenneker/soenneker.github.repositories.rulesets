using System.Text.Json.Serialization;

public record HrefObj
{
    [JsonPropertyName("href")]
    public string? Href { get; set; }
}