using Intellenum;

[Intellenum(typeof(string))]
public partial class ActorTypeEnum
{
    public static readonly ActorTypeEnum Integration = new(nameof(Integration));
    public static readonly ActorTypeEnum OrganizationAdmin = new(nameof(OrganizationAdmin));
    public static readonly ActorTypeEnum RepositoryRole = new(nameof(RepositoryRole));
    public static readonly ActorTypeEnum Team = new(nameof(Team));
    public static readonly ActorTypeEnum DeployKey = new(nameof(DeployKey));
}