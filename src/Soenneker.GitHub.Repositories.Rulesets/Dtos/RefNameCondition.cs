using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

/// <summary>
/// Represents the ref name condition record.
/// </summary>
public record RefNameCondition
{
    /// <summary>
    /// Gets or sets include.
    /// </summary>
    [JsonPropertyName("include")]
    public List<string>? Include { get; set; }

    /// <summary>
    /// Gets or sets exclude.
    /// </summary>
    [JsonPropertyName("exclude")]
    public List<string>? Exclude { get; set; }
}