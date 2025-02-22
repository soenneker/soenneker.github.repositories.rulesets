using Intellenum;

[Intellenum(typeof(string))]
public partial class BypassModeEnum
{
    public static readonly BypassModeEnum Always = new("always");
    public static readonly BypassModeEnum PullRequest = new("pullrequest");
}