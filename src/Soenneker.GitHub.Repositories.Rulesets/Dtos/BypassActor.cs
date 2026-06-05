using System.Text.Json.Serialization;
using Soenneker.GitHub.Repositories.Rulesets.Enums;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

/// <summary>
/// Represents the bypass actor record.
/// </summary>
public record BypassActor
{
    /// <summary>
    /// Gets or sets actor id.
    /// </summary>
    [JsonPropertyName("actor_id")]
    public int? ActorId { get; set; }

    /// <summary>
    /// Gets or sets actor type.
    /// </summary>
    [JsonPropertyName("actor_type")]
    public ActorTypeEnum ActorType { get; set; } = null!;

    /// <summary>
    /// Gets or sets bypass mode.
    /// </summary>
    [JsonPropertyName("bypass_mode")]
    public BypassModeEnum BypassMode { get; set; } = null!;
}