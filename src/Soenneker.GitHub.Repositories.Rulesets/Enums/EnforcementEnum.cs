using Soenneker.Gen.EnumValues;

namespace Soenneker.GitHub.Repositories.Rulesets.Enums;

/// <summary>
/// Represents the enforcement enum.
/// </summary>
[EnumValue<string>]
public partial class EnforcementEnum
{
    // Prevent JSON source generation from assuming an implicit public constructor.
    private EnforcementEnum() => throw new System.NotSupportedException("Use a declared enum value.");

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