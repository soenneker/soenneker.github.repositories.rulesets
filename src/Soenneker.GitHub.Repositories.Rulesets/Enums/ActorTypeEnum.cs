using Soenneker.Gen.EnumValues;

namespace Soenneker.GitHub.Repositories.Rulesets.Enums;

/// <summary>
/// Represents the actor type enum.
/// </summary>
[EnumValue<string>]
public partial class ActorTypeEnum
{
    /// <summary>
    /// The integration.
    /// </summary>
    public static readonly ActorTypeEnum Integration = new(nameof(Integration));
    /// <summary>
    /// The organization admin.
    /// </summary>
    public static readonly ActorTypeEnum OrganizationAdmin = new(nameof(OrganizationAdmin));
    /// <summary>
    /// The repository role.
    /// </summary>
    public static readonly ActorTypeEnum RepositoryRole = new(nameof(RepositoryRole));
    /// <summary>
    /// The team.
    /// </summary>
    public static readonly ActorTypeEnum Team = new(nameof(Team));
    /// <summary>
    /// The deploy key.
    /// </summary>
    public static readonly ActorTypeEnum DeployKey = new(nameof(DeployKey));
}