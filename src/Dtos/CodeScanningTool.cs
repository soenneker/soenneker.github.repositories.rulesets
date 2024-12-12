using System.Text.Json.Serialization;

public class CodeScanningTool
{
    [JsonPropertyName("tool")]
    public string Tool { get; set; } = default!;
}