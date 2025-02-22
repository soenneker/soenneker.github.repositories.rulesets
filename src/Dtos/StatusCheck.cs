using System.Text.Json.Serialization;

public record StatusCheck
{
    [JsonPropertyName("context")]
    public string Context { get; set; } = null!;

    [JsonPropertyName("integration_id")]
    public int? IntegrationId { get; set; }
}