using System.Text.Json.Serialization;

public record BypassActor
{
    [JsonPropertyName("actor_id")]
    public int? ActorId { get; set; }

    [JsonPropertyName("actor_type")]
    public ActorTypeEnum ActorType { get; set; } = null!;

    [JsonPropertyName("bypass_mode")]
    public BypassModeEnum BypassMode { get; set; } = null!;
}