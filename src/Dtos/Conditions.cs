using System.Text.Json.Serialization;

public class Conditions
{
    [JsonPropertyName("ref_name")]
    public RefNameCondition? RefName { get; set; }
}