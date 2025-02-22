using System.Text.Json.Serialization;

public record Rule
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("parameters")]
    public Parameters? Parameters { get; set; }
}