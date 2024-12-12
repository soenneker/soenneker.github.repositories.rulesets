using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Ardalis.SmartEnum.SystemTextJson;

public class RepositoryRuleset
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("source_type")]
    public string? SourceType { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("node_id")]
    public string? NodeId { get; set; }

    [JsonPropertyName("target")]
    [JsonConverter(typeof(SmartEnumNameConverter<TargetEnum, int>))]
    public TargetEnum Target { get; set; } = default!;

    [JsonPropertyName("enforcement")]
    [JsonConverter(typeof(SmartEnumNameConverter<EnforcementEnum, int>))]
    public EnforcementEnum Enforcement { get; set; } = default!;

    [JsonPropertyName("bypass_actors")]
    public List<BypassActor>? BypassActors { get; set; }

    [JsonPropertyName("conditions")]
    public Conditions? Conditions { get; set; }

    [JsonPropertyName("rules")]
    public List<Rule>? Rules { get; set; }

    [JsonPropertyName("_links")]
    public Links? Links { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
}