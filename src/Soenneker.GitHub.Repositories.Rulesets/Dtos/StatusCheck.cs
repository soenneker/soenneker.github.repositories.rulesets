using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

/// <summary>
/// Represents the status check record.
/// </summary>
public record StatusCheck
{
    /// <summary>
    /// Gets or sets context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; } = null!;

    /// <summary>
    /// Gets or sets integration id.
    /// </summary>
    [JsonPropertyName("integration_id")]
    public int? IntegrationId { get; set; }
}