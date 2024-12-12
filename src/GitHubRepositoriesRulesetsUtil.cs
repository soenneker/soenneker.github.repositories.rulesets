using Soenneker.GitHub.Repositories.Rulesets.Abstract;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using Soenneker.Extensions.ValueTask;
using Soenneker.GitHub.Client.Http.Abstract;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Soenneker.Extensions.Configuration;
using System;
using Microsoft.Extensions.Logging;
using Soenneker.Extensions.HttpResponseMessage;
using Soenneker.Extensions.Task;

namespace Soenneker.GitHub.Repositories.Rulesets;

/// <inheritdoc cref="IGitHubRepositoriesRulesetsUtil"/>
public class GitHubRepositoriesRulesetsUtil : IGitHubRepositoriesRulesetsUtil
{
    private readonly ILogger<GitHubRepositoriesRulesetsUtil> _logger;
    private readonly IGitHubHttpClient _gitHubHttpClient;
    private readonly string _token;

    public GitHubRepositoriesRulesetsUtil(ILogger<GitHubRepositoriesRulesetsUtil> logger, IGitHubHttpClient gitHubHttpClient, IConfiguration config)
    {
        _logger = logger;
        _gitHubHttpClient = gitHubHttpClient;
        _token = config.GetValueStrict<string>("GitHub:Token");
    }

    public async ValueTask<List<RepositoryRuleset>?> GetRulesets(string owner, string name, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Getting rulesets for repo ({owner}/{repo}) ...", owner, name);

        var url = $"repos/{owner}/{name}/rulesets";

        HttpRequestMessage request = CreateGitHubRequest(HttpMethod.Get, url);

        HttpClient client = await _gitHubHttpClient.Get(cancellationToken).NoSync();

        HttpResponseMessage responseMsg = await client.SendAsync(request, cancellationToken).NoSync();
        responseMsg.EnsureSuccessStatusCode();

        var response = await responseMsg.To<List<RepositoryRuleset>>(_logger, cancellationToken);

        return response;
    }

    public async ValueTask DeleteAllRulesets(string owner, string name, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Deleting all rulesets for repo ({owner}/{repo}) ...", owner, name);

        List<RepositoryRuleset>? rulesets = await GetRulesets(owner, name, cancellationToken).NoSync();

        if (rulesets != null)
        {
            foreach (RepositoryRuleset ruleset in rulesets)
            {
                await DeleteRuleset(owner, name, ruleset.Id.Value, cancellationToken).NoSync();
            }
        }
    }

    public async ValueTask DeleteRuleset(string owner, string name, int rulesetId, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Deleting ruleset ({rulesetId}) to repo ({owner}/{repo}) ...", rulesetId, owner, name);

        // Set up the request URL
        var url = $"repos/{owner}/{name}/rulesets/{rulesetId}";

        HttpRequestMessage request = CreateGitHubRequest(HttpMethod.Delete, url);

        HttpClient client = await _gitHubHttpClient.Get(cancellationToken).NoSync();

        // Send the request
        HttpResponseMessage response = await client.SendAsync(request, cancellationToken).NoSync();
        response.EnsureSuccessStatusCode();
    }

    public HttpRequestMessage CreateGitHubRequest(HttpMethod method, string url)
    {
        var request = new HttpRequestMessage(method, url);
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github+json"));
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        request.Headers.Add("X-GitHub-Api-Version", "2022-11-28");
        request.Headers.Add("User-Agent", Guid.NewGuid().ToString());

        return request;
    }
}