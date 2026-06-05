using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

/// <summary>
/// Represents the rule record.
/// </summary>
public record Rule
{
    /// <summary>
    /// Gets or sets type.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    /// <summary>
    /// Gets or sets parameters.
    /// </summary>
    [JsonPropertyName("parameters")]
    public Parameters? Parameters { get; set; }
}