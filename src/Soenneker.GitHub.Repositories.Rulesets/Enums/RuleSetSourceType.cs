using Soenneker.Gen.EnumValues;

namespace Soenneker.GitHub.Repositories.Rulesets.Enums;

[EnumValue<string>]
public partial class RuleSetSourceType
{
    public static readonly RuleSetSourceType Repository = new(nameof(Repository));
    public static readonly RuleSetSourceType Organization = new(nameof(Organization));
}