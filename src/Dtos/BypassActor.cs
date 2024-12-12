using System.Text.Json.Serialization;
using Ardalis.SmartEnum.SystemTextJson;

public class BypassActor
{
    [JsonPropertyName("actor_id")]
    public int? ActorId { get; set; }

    [JsonPropertyName("actor_type")]
    [JsonConverter(typeof(SmartEnumNameConverter<ActorTypeEnum, int>))]
    public ActorTypeEnum ActorType { get; set; } = default!;

    [JsonPropertyName("bypass_mode")]
    [JsonConverter(typeof(SmartEnumNameConverter<BypassModeEnum, int>))]
    public BypassModeEnum BypassMode { get; set; } = default!;
}