using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Soenneker.GitHub.Repositories.Rulesets.Dtos;

namespace Soenneker.GitHub.Repositories.Rulesets;

[JsonSourceGenerationOptions(JsonSerializerDefaults.Web, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, Converters = new[] { typeof(ActorTypeEnumWireConverter), typeof(BypassModeEnumWireConverter), typeof(TargetEnumWireConverter), typeof(EnforcementEnumWireConverter) })]
[JsonSerializable(typeof(RepositoryRuleset))]
[JsonSerializable(typeof(List<RepositoryRuleset>))]
internal partial class RulesetJsonContext : JsonSerializerContext;
