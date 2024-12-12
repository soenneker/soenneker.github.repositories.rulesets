using Ardalis.SmartEnum;
using Soenneker.Extensions.String;

public class BypassModeEnum : SmartEnum<BypassModeEnum>
{
    public static readonly BypassModeEnum Always = new(nameof(Always).ToLowerInvariantFast(), 0);
    public static readonly BypassModeEnum PullRequest = new(nameof(PullRequest).ToLowerInvariantFast(), 1);

    private BypassModeEnum(string name, int value) : base(name, value) { }
}