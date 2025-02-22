using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public record RepositoryRuleset
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("source_type")]
    public string? SourceType { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("node_id")]
    public string? NodeId { get; set; }

    [JsonPropertyName("target")]
    public TargetEnum Target { get; set; } = null!;

    [JsonPropertyName("enforcement")]
    public EnforcementEnum Enforcement { get; set; } = null!;

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