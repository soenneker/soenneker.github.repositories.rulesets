using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Soenneker.GitHub.Repositories.Rulesets.Enums;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

/// <summary>
/// Represents the repository ruleset record.
/// </summary>
public record RepositoryRuleset
{
    /// <summary>
    /// Gets or sets id.
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or sets name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets source type.
    /// </summary>
    [JsonPropertyName("source_type")]
    public string? SourceType { get; set; }

    /// <summary>
    /// Gets or sets source.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>
    /// Gets or sets node id.
    /// </summary>
    [JsonPropertyName("node_id")]
    public string? NodeId { get; set; }

    /// <summary>
    /// Gets or sets target.
    /// </summary>
    [JsonPropertyName("target")]
    public TargetEnum Target { get; set; } = null!;

    /// <summary>
    /// Gets or sets enforcement.
    /// </summary>
    [JsonPropertyName("enforcement")]
    public EnforcementEnum Enforcement { get; set; } = null!;

    /// <summary>
    /// Gets or sets bypass actors.
    /// </summary>
    [JsonPropertyName("bypass_actors")]
    public List<BypassActor>? BypassActors { get; set; }

    /// <summary>
    /// Gets or sets conditions.
    /// </summary>
    [JsonPropertyName("conditions")]
    public Conditions? Conditions { get; set; }

    /// <summary>
    /// Gets or sets rules.
    /// </summary>
    [JsonPropertyName("rules")]
    public List<Rule>? Rules { get; set; }

    /// <summary>
    /// Gets or sets links.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links? Links { get; set; }

    /// <summary>
    /// Gets or sets created at.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets updated at.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
}