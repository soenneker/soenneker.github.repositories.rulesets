using System.Text.Json.Serialization;
using Soenneker.GitHub.Repositories.Rulesets.Enums;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

public record BypassActor
{
    [JsonPropertyName("actor_id")]
    public int? ActorId { get; set; }

    [JsonPropertyName("actor_type")]
    public ActorTypeEnum ActorType { get; set; } = null!;

    [JsonPropertyName("bypass_mode")]
    public BypassModeEnum BypassMode { get; set; } = null!;
}