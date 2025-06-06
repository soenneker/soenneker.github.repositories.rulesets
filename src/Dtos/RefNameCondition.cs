using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

public record RefNameCondition
{
    [JsonPropertyName("include")]
    public List<string>? Include { get; set; }

    [JsonPropertyName("exclude")]
    public List<string>? Exclude { get; set; }
}