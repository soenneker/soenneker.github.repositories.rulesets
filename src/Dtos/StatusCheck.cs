using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

public record StatusCheck
{
    [JsonPropertyName("context")]
    public string Context { get; set; } = null!;

    [JsonPropertyName("integration_id")]
    public int? IntegrationId { get; set; }
}