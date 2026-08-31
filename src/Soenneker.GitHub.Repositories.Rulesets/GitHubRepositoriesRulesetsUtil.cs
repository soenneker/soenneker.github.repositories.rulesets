using Soenneker.GitHub.Repositories.Rulesets.Abstract;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using Soenneker.Extensions.ValueTask;
using Soenneker.GitHub.Client.Http.Abstract;
using Microsoft.Extensions.Logging;
using Soenneker.Extensions.Task;
using Soenneker.Extensions.Object;
using Soenneker.Extensions.HttpResponseMessage;
using Soenneker.GitHub.Repositories.Rulesets.Dtos;

namespace Soenneker.GitHub.Repositories.Rulesets;

public sealed class GitHubRepositoriesRulesetsUtil : IGitHubRepositoriesRulesetsUtil
{
    private readonly ILogger<GitHubRepositoriesRulesetsUtil> _logger;
    private readonly IGitHubHttpClient _gitHubHttpClient;

    public GitHubRepositoriesRulesetsUtil(ILogger<GitHubRepositoriesRulesetsUtil> logger, IGitHubHttpClient gitHubHttpClient)
    {
        _logger = logger;
        _gitHubHttpClient = gitHubHttpClient;
    }

    public async ValueTask Add(string owner, string name, RepositoryRuleset ruleset, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Adding ruleset to repo ({owner}/{repo}) branch ('main') ...", owner, name);

        var uri = $"repos/{owner}/{name}/rulesets";

        HttpClient client = await _gitHubHttpClient.Get(cancellationToken).NoSync();

        using var request = new HttpRequestMessage(HttpMethod.Post, uri);

        request.Content = ruleset.ToHttpContent();

        using HttpResponseMessage response = await client.SendAsync(request, cancellationToken).NoSync();
        response.EnsureSuccessStatusCode();
    }

    public async ValueTask<List<RepositoryRuleset>> GetAll(string owner, string name, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Getting rulesets for repo ({owner}/{repo}) ...", owner, name);

        HttpClient client = await _gitHubHttpClient.Get(cancellationToken).NoSync();
        var rulesets = new List<RepositoryRuleset>();
        var page = 1;
        const int perPage = 100;

        while (true)
        {
            var url = $"repos/{owner}/{name}/rulesets?per_page={perPage}&page={page}";
            using var request = new HttpRequestMessage(HttpMethod.Get, url);
            using HttpResponseMessage response = await client.SendAsync(request, cancellationToken).NoSync();
            response.EnsureSuccessStatusCode();

            List<RepositoryRuleset>? pageOfRulesets = await response.To<List<RepositoryRuleset>>(_logger, cancellationToken).NoSync();

            if (pageOfRulesets == null || pageOfRulesets.Count == 0)
                break;

            rulesets.AddRange(pageOfRulesets);

            if (pageOfRulesets.Count < perPage)
                break;

            page++;
        }

        return rulesets;
    }

    public async ValueTask DeleteAll(string owner, string name, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Deleting all rulesets for repo ({owner}/{repo}) ...", owner, name);

        List<RepositoryRuleset> rulesets = await GetAll(owner, name, cancellationToken).NoSync();

        for (var i = 0; i < rulesets.Count; i++)
        {
            RepositoryRuleset ruleset = rulesets[i];

            if (ruleset.Id is not int rulesetId)
                throw new System.InvalidOperationException("GitHub returned a repository ruleset without an ID.");

            await Delete(owner, name, rulesetId, cancellationToken).NoSync();
        }
    }

    public async ValueTask Delete(string owner, string name, int rulesetId, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Deleting ruleset ({rulesetId}) to repo ({owner}/{repo}) ...", rulesetId, owner, name);

        // Set up the request URL
        var url = $"repos/{owner}/{name}/rulesets/{rulesetId}";

        using var request = new HttpRequestMessage(HttpMethod.Delete, url);

        HttpClient client = await _gitHubHttpClient.Get(cancellationToken).NoSync();

        // Send the request
        using HttpResponseMessage response = await client.SendAsync(request, cancellationToken).NoSync();
        response.EnsureSuccessStatusCode();
    }
}
