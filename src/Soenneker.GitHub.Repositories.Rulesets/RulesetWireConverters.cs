using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Soenneker.GitHub.Repositories.Rulesets.Enums;

namespace Soenneker.GitHub.Repositories.Rulesets;

internal sealed class ActorTypeEnumWireConverter : JsonConverter<ActorTypeEnum>
{
    private static readonly ActorTypeEnumJsonConverter _converter = new();

    public override ActorTypeEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        _converter.Read(ref reader, typeToConvert, options);

    public override void Write(Utf8JsonWriter writer, ActorTypeEnum value, JsonSerializerOptions options) =>
        _converter.Write(writer, value, options);
}

internal sealed class BypassModeEnumWireConverter : JsonConverter<BypassModeEnum>
{
    private static readonly BypassModeEnumJsonConverter _converter = new();

    public override BypassModeEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        _converter.Read(ref reader, typeToConvert, options);

    public override void Write(Utf8JsonWriter writer, BypassModeEnum value, JsonSerializerOptions options) =>
        _converter.Write(writer, value, options);
}

internal sealed class TargetEnumWireConverter : JsonConverter<TargetEnum>
{
    private static readonly TargetEnumJsonConverter _converter = new();

    public override TargetEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        _converter.Read(ref reader, typeToConvert, options);

    public override void Write(Utf8JsonWriter writer, TargetEnum value, JsonSerializerOptions options) =>
        _converter.Write(writer, value, options);
}

internal sealed class EnforcementEnumWireConverter : JsonConverter<EnforcementEnum>
{
    private static readonly EnforcementEnumJsonConverter _converter = new();

    public override EnforcementEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        _converter.Read(ref reader, typeToConvert, options);

    public override void Write(Utf8JsonWriter writer, EnforcementEnum value, JsonSerializerOptions options) =>
        _converter.Write(writer, value, options);
}

