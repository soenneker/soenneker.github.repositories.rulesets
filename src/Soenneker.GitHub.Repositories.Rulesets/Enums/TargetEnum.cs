using Soenneker.Gen.EnumValues;

namespace Soenneker.GitHub.Repositories.Rulesets.Enums;

[EnumValue<string>]
public partial class TargetEnum
{
    public static readonly TargetEnum Branch = new("branch");
    public static readonly TargetEnum Tag = new("tag");
    public static readonly TargetEnum Push = new("push");
}