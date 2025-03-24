using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Rulesets.Dtos;

public record Parameters
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    [JsonPropertyName("update_allows_fetch_and_merge")]
    public bool? UpdateAllowsFetchAndMerge { get; set; }

    [JsonPropertyName("required_deployment_environments")]
    public List<string>? RequiredDeploymentEnvironments { get; set; }

    [JsonPropertyName("dismiss_stale_reviews_on_push")]
    public bool? DismissStaleReviewsOnPush { get; set; }

    [JsonPropertyName("require_code_owner_review")]
    public bool? RequireCodeOwnerReview { get; set; }

    [JsonPropertyName("require_last_push_approval")]
    public bool? RequireLastPushApproval { get; set; }

    [JsonPropertyName("required_approving_review_count")]
    public int? RequiredApprovingReviewCount { get; set; }

    [JsonPropertyName("required_review_thread_resolution")]
    public bool? RequiredReviewThreadResolution { get; set; }

    [JsonPropertyName("required_status_checks")]
    public List<StatusCheck>? RequiredStatusChecks { get; set; }

    [JsonPropertyName("strict_required_status_checks_policy")]
    public bool? StrictRequiredStatusChecksPolicy { get; set; }

    [JsonPropertyName("restricted_file_paths")]
    public List<string>? RestrictedFilePaths { get; set; }

    [JsonPropertyName("max_file_path_length")]
    public int? MaxFilePathLength { get; set; }

    [JsonPropertyName("restricted_file_extensions")]
    public List<string>? RestrictedFileExtensions { get; set; }

    [JsonPropertyName("max_file_size")]
    public int? MaxFileSize { get; set; }

    [JsonPropertyName("workflows")]
    public List<Workflow>? Workflows { get; set; }

    [JsonPropertyName("code_scanning_tools")]
    public List<CodeScanningTool>? CodeScanningTools { get; set; }

    [JsonPropertyName("alerts_threshold")]
    public string? AlertsThreshold { get; set; }

    [JsonPropertyName("security_alerts_threshold")]
    public string? SecurityAlertsThreshold { get; set; }
}