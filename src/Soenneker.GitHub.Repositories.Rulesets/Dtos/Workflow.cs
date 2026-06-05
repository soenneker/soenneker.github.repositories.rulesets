using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

/// <summary>
/// Represents the workflow record.
/// </summary>
public record Workflow
{
    /// <summary>
    /// Gets or sets path.
    /// </summary>
    [JsonPropertyName("path")]
    public string Path { get; set; } = null!;

    /// <summary>
    /// Gets or sets ref.
    /// </summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>
    /// Gets or sets repository id.
    /// </summary>
    [JsonPropertyName("repository_id")]
    public int RepositoryId { get; set; } = 0!;

    /// <summary>
    /// Gets or sets sha.
    /// </summary>
    [JsonPropertyName("sha")]
    public string? Sha { get; set; }
}