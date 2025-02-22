using System.Text.Json.Serialization;

public record Links
{
    [JsonPropertyName("self")]
    public HrefObj? Self { get; set; }

    [JsonPropertyName("html")]
    public HrefObj? Html { get; set; }
}