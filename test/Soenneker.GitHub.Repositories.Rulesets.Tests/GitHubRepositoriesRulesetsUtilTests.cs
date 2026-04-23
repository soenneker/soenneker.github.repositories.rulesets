using Soenneker.GitHub.Repositories.Rulesets.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.GitHub.Repositories.Rulesets.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class GitHubRepositoriesRulesetsUtilTests : HostedUnitTest
{
    private readonly IGitHubRepositoriesRulesetsUtil _util;

    public GitHubRepositoriesRulesetsUtilTests(Host host) : base(host)
    {
        _util = Resolve<IGitHubRepositoriesRulesetsUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
