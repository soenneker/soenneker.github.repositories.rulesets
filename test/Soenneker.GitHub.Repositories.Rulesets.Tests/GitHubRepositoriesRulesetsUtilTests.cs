using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Soenneker.GitHub.Repositories.Rulesets.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;


namespace Soenneker.GitHub.Repositories.Rulesets.Tests;

[Collection("Collection")]
public class GitHubRepositoriesRulesetsUtilTests : FixturedUnitTest
{
    private readonly IGitHubRepositoriesRulesetsUtil _util;

    public GitHubRepositoriesRulesetsUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IGitHubRepositoriesRulesetsUtil>(true);
    }
}
