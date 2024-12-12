using System.Text.Json.Serialization;

public class Workflow
{
    [JsonPropertyName("path")]
    public string Path { get; set; } = default!;

    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    [JsonPropertyName("repository_id")]
    public int RepositoryId { get; set; } = default!;

    [JsonPropertyName("sha")]
    public string? Sha { get; set; }
}