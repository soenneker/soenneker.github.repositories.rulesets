using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

public record HrefObj
{
    [JsonPropertyName("href")]
    public string? Href { get; set; }
}