using Soenneker.Gen.EnumValues;

namespace Soenneker.GitHub.Repositories.Rulesets.Enums;

[EnumValue<string>]
public partial class BypassModeEnum
{
    public static readonly BypassModeEnum Always = new("always");
    public static readonly BypassModeEnum PullRequest = new("pullrequest");
}