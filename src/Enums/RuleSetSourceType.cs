using Intellenum;

[Intellenum(typeof(string))]
public partial class RuleSetSourceType
{
    public static readonly RuleSetSourceType Repository = new(nameof(Repository));
    public static readonly RuleSetSourceType Organization = new(nameof(Organization));
}