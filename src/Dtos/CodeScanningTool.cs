using System.Text.Json.Serialization;

public record CodeScanningTool
{
    [JsonPropertyName("tool")]
    public string Tool { get; set; } = null!;
}