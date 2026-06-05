using Soenneker.Gen.EnumValues;

namespace Soenneker.GitHub.Repositories.Rulesets.Enums;

/// <summary>
/// Represents the rule set source type.
/// </summary>
[EnumValue<string>]
public partial class RuleSetSourceType
{
    /// <summary>
    /// The repository.
    /// </summary>
    public static readonly RuleSetSourceType Repository = new(nameof(Repository));
    /// <summary>
    /// The organization.
    /// </summary>
    public static readonly RuleSetSourceType Organization = new(nameof(Organization));
}