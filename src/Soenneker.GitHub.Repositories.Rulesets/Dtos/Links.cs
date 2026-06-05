using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

/// <summary>
/// Represents the links record.
/// </summary>
public record Links
{
    /// <summary>
    /// Gets or sets self.
    /// </summary>
    [JsonPropertyName("self")]
    public HrefObj? Self { get; set; }

    /// <summary>
    /// Gets or sets html.
    /// </summary>
    [JsonPropertyName("html")]
    public HrefObj? Html { get; set; }
}