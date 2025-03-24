using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

public record Workflow
{
    [JsonPropertyName("path")]
    public string Path { get; set; } = null!;

    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    [JsonPropertyName("repository_id")]
    public int RepositoryId { get; set; } = 0!;

    [JsonPropertyName("sha")]
    public string? Sha { get; set; }
}