using Soenneker.Gen.EnumValues;

namespace Soenneker.GitHub.Repositories.Rulesets.Enums;

/// <summary>
/// Represents the bypass mode enum.
/// </summary>
[EnumValue<string>]
public partial class BypassModeEnum
{
    /// <summary>
    /// The always.
    /// </summary>
    public static readonly BypassModeEnum Always = new("always");
    /// <summary>
    /// The pull request.
    /// </summary>
    public static readonly BypassModeEnum PullRequest = new("pullrequest");
}