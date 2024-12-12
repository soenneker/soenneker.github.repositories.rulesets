using System.Text.Json.Serialization;

public class Links
{
    [JsonPropertyName("self")]
    public HrefObj? Self { get; set; }

    [JsonPropertyName("html")]
    public HrefObj? Html { get; set; }
}