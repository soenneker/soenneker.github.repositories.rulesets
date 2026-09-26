using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Soenneker.GitHub.Client.Http.Abstract;
using Soenneker.GitHub.Repositories.Rulesets.Dtos;
using Soenneker.GitHub.Repositories.Rulesets.Enums;

namespace Soenneker.GitHub.Repositories.Rulesets.Tests;

public sealed class RulesetSerializationTests
{
    [Test]
    public async Task Rulesets_preserve_enum_wire_values_in_both_directions()
    {
        using var handler = new CaptureHandler();
        using var client = new ClientProvider(handler);
        var util = new GitHubRepositoriesRulesetsUtil(NullLogger<GitHubRepositoriesRulesetsUtil>.Instance, client);
        var ruleset = new RepositoryRuleset
        {
            Name = "main",
            Target = TargetEnum.Branch,
            Enforcement = EnforcementEnum.Active,
            BypassActors = [new BypassActor { ActorId = 1, ActorType = ActorTypeEnum.Team, BypassMode = BypassModeEnum.Always }]
        };

        await util.Add("owner", "repo", ruleset);
        using JsonDocument body = JsonDocument.Parse(handler.Body!);
        if (body.RootElement.GetProperty("target").GetString() != "branch"
            || body.RootElement.GetProperty("enforcement").GetString() != "active"
            || body.RootElement.GetProperty("bypass_actors")[0].GetProperty("actor_type").GetString() != "Team")
            throw new InvalidOperationException("Ruleset enum values were not serialized as GitHub strings.");

        var result = await util.GetAll("owner", "repo");
        if (result.Count != 1 || result[0].Target != TargetEnum.Branch || result[0].Enforcement != EnforcementEnum.Active
            || result[0].BypassActors![0].ActorType != ActorTypeEnum.Team || result[0].BypassActors![0].BypassMode != BypassModeEnum.Always)
            throw new InvalidOperationException("Ruleset enum values did not round trip.");
    }

    private sealed class CaptureHandler : HttpMessageHandler
    {
        internal string? Body;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.Method == HttpMethod.Post)
                Body = await request.Content!.ReadAsStringAsync(cancellationToken);
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(request.Method == HttpMethod.Get ? "[" + Body + "]" : "{}") };
        }
    }

    private sealed class ClientProvider(HttpMessageHandler handler) : IGitHubHttpClient
    {
        private readonly HttpClient _client = new(handler, false) { BaseAddress = new Uri("https://api.github.test/") };
        public ValueTask<HttpClient> Get(CancellationToken cancellationToken = default) => ValueTask.FromResult(_client);
        public ValueTask<HttpClient> GetForUpload(CancellationToken cancellationToken = default) => ValueTask.FromResult(_client);
        public void Dispose() => _client.Dispose();
        public ValueTask DisposeAsync() { Dispose(); return ValueTask.CompletedTask; }
    }
}
