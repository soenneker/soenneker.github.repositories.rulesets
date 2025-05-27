using Soenneker.GitHub.Repositories.Rulesets.Abstract;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using Soenneker.Extensions.ValueTask;
using Soenneker.GitHub.Client.Http.Abstract;
using Microsoft.Extensions.Logging;
using Soenneker.Extensions.HttpResponseMessage;
using Soenneker.Extensions.Task;
using Soenneker.Extensions.Object;
using Soenneker.Extensions.HttpClient;
using Soenneker.GitHub.Repositories.Rulesets.Dtos;

namespace Soenneker.GitHub.Repositories.Rulesets;

/// <inheritdoc cref="IGitHubRepositoriesRulesetsUtil"/>
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

        (bool successful, HttpResponseMessage? response) = await client.TrySend(request, _logger, cancellationToken).NoSync();

        if (!successful)
        {
            if (response != null)
            {
                string? errorContent = await response.ToStringSafe(_logger, cancellationToken).NoSync();
                _logger.LogError("Failed to add ruleset: {StatusCode} - {ErrorContent}", response.StatusCode, errorContent);
            }
            else
                _logger.LogError("Failed to add ruleset");
        }
    }

    public async ValueTask<List<RepositoryRuleset>?> GetAll(string owner, string name, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Getting rulesets for repo ({owner}/{repo}) ...", owner, name);

        var url = $"repos/{owner}/{name}/rulesets";

        using var request = new HttpRequestMessage(HttpMethod.Get, url);

        HttpClient client = await _gitHubHttpClient.Get(cancellationToken).NoSync();

        HttpResponseMessage responseMsg = await client.SendAsync(request, cancellationToken).NoSync();
        responseMsg.EnsureSuccessStatusCode();

        return await responseMsg.To<List<RepositoryRuleset>>(_logger, cancellationToken);
    }

    public async ValueTask DeleteAll(string owner, string name, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Deleting all rulesets for repo ({owner}/{repo}) ...", owner, name);

        List<RepositoryRuleset>? rulesets = await GetAll(owner, name, cancellationToken).NoSync();

        if (rulesets != null)
        {
            foreach (RepositoryRuleset ruleset in rulesets)
            {
                await Delete(owner, name, ruleset.Id.Value, cancellationToken).NoSync();
            }
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
        HttpResponseMessage response = await client.SendAsync(request, cancellationToken).NoSync();
        response.EnsureSuccessStatusCode();
    }
}