using Intellenum;

namespace Soenneker.GitHub.Repositories.Rulesets.Enums;

[Intellenum(typeof(string))]
public partial class EnforcementEnum
{
    public static readonly EnforcementEnum Disabled = new("disabled");
    public static readonly EnforcementEnum Active = new("active");
    public static readonly EnforcementEnum Evaluate = new("evaluate");
}