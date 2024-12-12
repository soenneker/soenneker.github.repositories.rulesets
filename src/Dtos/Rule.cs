using System.Text.Json.Serialization;

public class Rule
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("parameters")]
    public Parameters? Parameters { get; set; }
}