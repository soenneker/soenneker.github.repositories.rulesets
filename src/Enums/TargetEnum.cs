using Ardalis.SmartEnum;
using Soenneker.Extensions.String;

public class TargetEnum : SmartEnum<TargetEnum>
{
    public static readonly TargetEnum Branch = new(nameof(Branch).ToLowerInvariantFast(), 0);
    public static readonly TargetEnum Tag = new(nameof(Tag).ToLowerInvariantFast(), 1);
    public static readonly TargetEnum Push = new(nameof(Push).ToLowerInvariantFast(), 2);

    private TargetEnum(string name, int value) : base(name, value) { }
}