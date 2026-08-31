[![](https://img.shields.io/nuget/v/soenneker.github.repositories.rulesets.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.github.repositories.rulesets/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.github.repositories.rulesets/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.github.repositories.rulesets/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.github.repositories.rulesets.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.github.repositories.rulesets/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.github.repositories.rulesets/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.github.repositories.rulesets/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.GitHub.Repositories.Rulesets

Create, inspect, and remove repository-level GitHub rulesets for branches, tags, or pushes.

## Installation

```bash
dotnet add package Soenneker.GitHub.Repositories.Rulesets
```

## Configuration

```json
{
  "GH": {
    "Token": "github-token"
  }
}
```

The token needs repository administration permission to create or delete rulesets.

## Registration

```csharp
services.AddGitHubRepositoriesRulesetsUtilAsSingleton();
```

Use `AddGitHubRepositoriesRulesetsUtilAsScoped()` for a scoped consumer.

## Create a ruleset

```csharp
var ruleset = new RepositoryRuleset
{
    Name = "Protect main",
    Target = TargetEnum.Branch,
    Enforcement = EnforcementEnum.Active,
    Conditions = new Conditions
    {
        RefName = new RefNameCondition
        {
            Include = ["refs/heads/main"]
        }
    },
    Rules =
    [
        new Rule { Type = "deletion" },
        new Rule { Type = "non_fast_forward" }
    ]
};

await rulesets.Add(
    "soenneker",
    "example-repository",
    ruleset,
    cancellationToken);
```

`RepositoryRuleset` maps directly to GitHub's ruleset request shape. Rule types and their `Parameters` must be valid for the selected target.

## List or delete rulesets

```csharp
List<RepositoryRuleset> existing = await rulesets.GetAll(
    "soenneker",
    "example-repository",
    cancellationToken);

await rulesets.Delete(
    "soenneker",
    "example-repository",
    rulesetId,
    cancellationToken);
```

`GetAll` follows pagination and returns all visible repository rulesets. `DeleteAll` permanently removes every ruleset returned for the repository; it does not preserve or recreate their policies.
