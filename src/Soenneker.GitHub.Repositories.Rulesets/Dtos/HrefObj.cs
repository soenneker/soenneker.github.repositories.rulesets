using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

/// <summary>
/// Represents the href obj record.
/// </summary>
public record HrefObj
{
    /// <summary>
    /// Gets or sets href.
    /// </summary>
    [JsonPropertyName("href")]
    public string? Href { get; set; }
}