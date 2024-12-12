using Ardalis.SmartEnum;

public sealed class RuleSetSourceType : SmartEnum<RuleSetSourceType>
{
    public static readonly RuleSetSourceType Repository = new RuleSetSourceType(nameof(Repository), 1);
    public static readonly RuleSetSourceType Organization = new RuleSetSourceType(nameof(Organization), 2);

    private RuleSetSourceType(string name, int value) : base(name, value)
    {
    }
}