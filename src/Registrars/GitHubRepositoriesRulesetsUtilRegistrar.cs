using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.GitHub.Client.Http.Registrars;
using Soenneker.GitHub.Repositories.Rulesets.Abstract;

namespace Soenneker.GitHub.Repositories.Rulesets.Registrars;

/// <summary>
/// A utility library for GitHub repository ruleset related operations
/// </summary>
public static class GitHubRepositoriesRulesetsUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="IGitHubRepositoriesRulesetsUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddGitHubRepositoriesRulesetsUtilAsSingleton(this IServiceCollection services)
    {
        services.AddGitHubHttpClientAsSingleton();
        services.TryAddSingleton<IGitHubRepositoriesRulesetsUtil, GitHubRepositoriesRulesetsUtil>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="IGitHubRepositoriesRulesetsUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddGitHubRepositoriesRulesetsUtilAsScoped(this IServiceCollection services)
    {
        services.AddGitHubHttpClientAsSingleton();
        services.TryAddScoped<IGitHubRepositoriesRulesetsUtil, GitHubRepositoriesRulesetsUtil>();

        return services;
    }
}
