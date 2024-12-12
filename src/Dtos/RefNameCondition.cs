using System.Collections.Generic;
using System.Text.Json.Serialization;

public class RefNameCondition
{
    [JsonPropertyName("include")]
    public List<string>? Include { get; set; }

    [JsonPropertyName("exclude")]
    public List<string>? Exclude { get; set; }
}