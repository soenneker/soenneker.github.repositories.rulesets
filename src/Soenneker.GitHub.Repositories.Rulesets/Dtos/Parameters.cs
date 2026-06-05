using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

/// <summary>
/// Represents the parameters record.
/// </summary>
public record Parameters
{
    /// <summary>
    /// Gets or sets name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether negate.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// Gets or sets operator.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// Gets or sets pattern.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether update allows fetch and merge.
    /// </summary>
    [JsonPropertyName("update_allows_fetch_and_merge")]
    public bool? UpdateAllowsFetchAndMerge { get; set; }

    /// <summary>
    /// Gets or sets required deployment environments.
    /// </summary>
    [JsonPropertyName("required_deployment_environments")]
    public List<string>? RequiredDeploymentEnvironments { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether dismiss stale reviews on push.
    /// </summary>
    [JsonPropertyName("dismiss_stale_reviews_on_push")]
    public bool? DismissStaleReviewsOnPush { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether require code owner review.
    /// </summary>
    [JsonPropertyName("require_code_owner_review")]
    public bool? RequireCodeOwnerReview { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether require last push approval.
    /// </summary>
    [JsonPropertyName("require_last_push_approval")]
    public bool? RequireLastPushApproval { get; set; }

    /// <summary>
    /// Gets or sets required approving review count.
    /// </summary>
    [JsonPropertyName("required_approving_review_count")]
    public int? RequiredApprovingReviewCount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether required review thread resolution.
    /// </summary>
    [JsonPropertyName("required_review_thread_resolution")]
    public bool? RequiredReviewThreadResolution { get; set; }

    /// <summary>
    /// Gets or sets required status checks.
    /// </summary>
    [JsonPropertyName("required_status_checks")]
    public List<StatusCheck>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether strict required status checks policy.
    /// </summary>
    [JsonPropertyName("strict_required_status_checks_policy")]
    public bool? StrictRequiredStatusChecksPolicy { get; set; }

    /// <summary>
    /// Gets or sets restricted file paths.
    /// </summary>
    [JsonPropertyName("restricted_file_paths")]
    public List<string>? RestrictedFilePaths { get; set; }

    /// <summary>
    /// Gets or sets max file path length.
    /// </summary>
    [JsonPropertyName("max_file_path_length")]
    public int? MaxFilePathLength { get; set; }

    /// <summary>
    /// Gets or sets restricted file extensions.
    /// </summary>
    [JsonPropertyName("restricted_file_extensions")]
    public List<string>? RestrictedFileExtensions { get; set; }

    /// <summary>
    /// Gets or sets max file size.
    /// </summary>
    [JsonPropertyName("max_file_size")]
    public int? MaxFileSize { get; set; }

    /// <summary>
    /// Gets or sets workflows.
    /// </summary>
    [JsonPropertyName("workflows")]
    public List<Workflow>? Workflows { get; set; }

    /// <summary>
    /// Gets or sets code scanning tools.
    /// </summary>
    [JsonPropertyName("code_scanning_tools")]
    public List<CodeScanningTool>? CodeScanningTools { get; set; }

    /// <summary>
    /// Gets or sets alerts threshold.
    /// </summary>
    [JsonPropertyName("alerts_threshold")]
    public string? AlertsThreshold { get; set; }

    /// <summary>
    /// Gets or sets security alerts threshold.
    /// </summary>
    [JsonPropertyName("security_alerts_threshold")]
    public string? SecurityAlertsThreshold { get; set; }
}