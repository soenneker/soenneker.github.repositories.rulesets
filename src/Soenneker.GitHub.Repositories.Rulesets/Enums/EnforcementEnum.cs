using Soenneker.Gen.EnumValues;

namespace Soenneker.GitHub.Repositories.Rulesets.Enums;

/// <summary>
/// Represents the enforcement enum.
/// </summary>
[EnumValue<string>]
public partial class EnforcementEnum
{
    /// <summary>
    /// The disabled.
    /// </summary>
    public static readonly EnforcementEnum Disabled = new("disabled");
    /// <summary>
    /// The active.
    /// </summary>
    public static readonly EnforcementEnum Active = new("active");
    /// <summary>
    /// The evaluate.
    /// </summary>
    public static readonly EnforcementEnum Evaluate = new("evaluate");
}