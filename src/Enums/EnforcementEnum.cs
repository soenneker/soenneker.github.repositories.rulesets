using Ardalis.SmartEnum;
using Soenneker.Extensions.String;

public class EnforcementEnum : SmartEnum<EnforcementEnum>
{
    public static readonly EnforcementEnum Disabled = new(nameof(Disabled).ToLowerInvariantFast(), 0);
    public static readonly EnforcementEnum Active = new(nameof(Active).ToLowerInvariantFast(), 1);
    public static readonly EnforcementEnum Evaluate = new(nameof(Evaluate).ToLowerInvariantFast(), 2);

    private EnforcementEnum(string name, int value) : base(name, value) { }
}