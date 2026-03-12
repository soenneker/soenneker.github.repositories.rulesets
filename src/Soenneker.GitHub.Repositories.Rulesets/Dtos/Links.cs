using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

public record Links
{
    [JsonPropertyName("self")]
    public HrefObj? Self { get; set; }

    [JsonPropertyName("html")]
    public HrefObj? Html { get; set; }
}