using Soenneker.Gen.EnumValues;

namespace Soenneker.GitHub.Repositories.Rulesets.Enums;

/// <summary>
/// Represents the bypass mode enum.
/// </summary>
[EnumValue<string>]
public partial class BypassModeEnum
{
    // Prevent JSON source generation from assuming an implicit public constructor.
    private BypassModeEnum() => throw new System.NotSupportedException("Use a declared enum value.");

    /// <summary>
    /// The always.
    /// </summary>
    public static readonly BypassModeEnum Always = new("always");
    /// <summary>
    /// The pull request.
    /// </summary>
    public static readonly BypassModeEnum PullRequest = new("pullrequest");
}