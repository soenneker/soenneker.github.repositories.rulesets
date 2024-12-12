using System.Text.Json.Serialization;

public class StatusCheck
{
    [JsonPropertyName("context")]
    public string Context { get; set; } = default!;

    [JsonPropertyName("integration_id")]
    public int? IntegrationId { get; set; }
}