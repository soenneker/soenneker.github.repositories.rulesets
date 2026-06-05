using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

/// <summary>
/// Represents the conditions record.
/// </summary>
public record Conditions
{
    /// <summary>
    /// Gets or sets ref name.
    /// </summary>
    [JsonPropertyName("ref_name")]
    public RefNameCondition? RefName { get; set; }
}