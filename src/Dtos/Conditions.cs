using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

public record Conditions
{
    [JsonPropertyName("ref_name")]
    public RefNameCondition? RefName { get; set; }
}