using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

public record CodeScanningTool
{
    [JsonPropertyName("tool")]
    public string Tool { get; set; } = null!;
}