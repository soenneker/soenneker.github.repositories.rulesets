using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

public record Rule
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("parameters")]
    public Parameters? Parameters { get; set; }
}