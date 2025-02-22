using System.Text.Json.Serialization;

public record Conditions
{
    [JsonPropertyName("ref_name")]
    public RefNameCondition? RefName { get; set; }
}