using Soenneker.Gen.EnumValues;

namespace Soenneker.GitHub.Repositories.Rulesets.Enums;

/// <summary>
/// Represents the target enum.
/// </summary>
[EnumValue<string>]
public partial class TargetEnum
{
    /// <summary>
    /// The branch.
    /// </summary>
    public static readonly TargetEnum Branch = new("branch");
    /// <summary>
    /// The tag.
    /// </summary>
    public static readonly TargetEnum Tag = new("tag");
    /// <summary>
    /// The push.
    /// </summary>
    public static readonly TargetEnum Push = new("push");
}