using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

/// <summary>
/// Represents the code scanning tool record.
/// </summary>
public record CodeScanningTool
{
    /// <summary>
    /// Gets or sets tool.
    /// </summary>
    [JsonPropertyName("tool")]
    public string Tool { get; set; } = null!;
}