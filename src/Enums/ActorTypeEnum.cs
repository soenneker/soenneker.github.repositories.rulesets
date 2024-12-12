using Ardalis.SmartEnum;

public class ActorTypeEnum : SmartEnum<ActorTypeEnum>
{
    public static readonly ActorTypeEnum Integration = new(nameof(Integration), 0);
    public static readonly ActorTypeEnum OrganizationAdmin = new(nameof(OrganizationAdmin), 1);
    public static readonly ActorTypeEnum RepositoryRole = new(nameof(RepositoryRole), 2);
    public static readonly ActorTypeEnum Team = new(nameof(Team), 3);
    public static readonly ActorTypeEnum DeployKey = new(nameof(DeployKey), 4);

    private ActorTypeEnum(string name, int value) : base(name, value) { }
}