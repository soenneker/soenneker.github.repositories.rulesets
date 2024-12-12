using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.GitHub.Repositories.Rulesets.Abstract;

/// <summary>
/// A utility library for GitHub repository ruleset related operations
/// </summary>
public interface IGitHubRepositoriesRulesetsUtil
{
    /// <summary>
    /// Retrieves the list of repository rulesets for the specified owner and repository name.
    /// </summary>
    /// <param name="owner">The owner of the repository.</param>
    /// <param name="name">The name of the repository.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>
    /// A <see cref="ValueTask{TResult}"/> representing the asynchronous operation. The result contains a list of <see cref="RepositoryRuleset"/> 
    /// if rulesets are found, or <c>null</c> if no rulesets are available.
    /// </returns>
    ValueTask<List<RepositoryRuleset>?> GetRulesets(string owner, string name, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes all rulesets for the specified owner and repository name.
    /// </summary>
    /// <param name="owner">The owner of the repository.</param>
    /// <param name="name">The name of the repository.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>
    /// A <see cref="ValueTask"/> representing the asynchronous operation.
    /// </returns>
    ValueTask DeleteAllRulesets(string owner, string name, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a specific ruleset by ID for the specified owner and repository name.
    /// </summary>
    /// <param name="owner">The owner of the repository.</param>
    /// <param name="name">The name of the repository.</param>
    /// <param name="rulesetId">The ID of the ruleset to delete.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>
    /// A <see cref="ValueTask"/> representing the asynchronous operation.
    /// </returns>
    ValueTask DeleteRuleset(string owner, string name, int rulesetId, CancellationToken cancellationToken = default);

}