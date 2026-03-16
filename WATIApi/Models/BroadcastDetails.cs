using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a detailed broadcast object.
    /// </summary>
    [DataContract(Name = "BroadcastDetailsDto")]
    public partial class BroadcastDetails {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastDetailsDto" /> class.
        /// </summary>
        /// <param name="id">The identifier of the broadcast.</param>
        /// <param name="channelID">The identifier of the channel associated with the broadcast.</param>
        /// <param name="name">The name of the broadcast.</param>
        /// <param name="status">The status of the broadcast.</param>
        /// <param name="templateID">The identifier of the message template used in the broadcast.</param>
        /// <param name="fallbackTemplates">The fallback templates used in the broadcast.</param>
        /// <param name="created">The creation timestamp of the broadcast.</param>
        /// <param name="lastUpdated">The last updated timestamp of the broadcast.</param>
        /// <param name="scheduledAt">The scheduled time for the broadcast.</param>
        /// <param name="statistics">statistics.</param>
        public BroadcastDetails(string? id = null, string? channelID = null, string? name = null, string? status = null, string? templateID = null, List<FallbackTemplate>? fallbackTemplates = null, DateTime created = default, DateTime lastUpdated = default, DateTime scheduledAt = default, BroadcastStatistics statistics = default) {
            this.ID = id;
            this.ChannelID = channelID;
            this.Name = name;
            this.Status = status;
            this.TemplateID = templateID;
            this.FallbackTemplates = fallbackTemplates;
            this.Created = created;
            this.LastUpdated = lastUpdated;
            this.ScheduledAt = scheduledAt;
            this.Statistics = statistics;
        }

        /// <summary>
        /// The identifier of the broadcast
        /// </summary>
        /// <value>The identifier of the broadcast</value>
        [JsonPropertyName("id")]
        public string? ID { get; set; }

        /// <summary>
        /// The identifier of the channel associated with the broadcast
        /// </summary>
        /// <value>The identifier of the channel associated with the broadcast</value>
        [JsonPropertyName("channel_id")]
        public string? ChannelID { get; set; }

        /// <summary>
        /// The name of the broadcast
        /// </summary>
        /// <value>The name of the broadcast</value>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The status of the broadcast
        /// </summary>
        /// <value>The status of the broadcast</value>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The identifier of the message template used in the broadcast
        /// </summary>
        /// <value>The identifier of the message template used in the broadcast</value>
        [JsonPropertyName("template_id")]
        public string? TemplateID { get; set; }

        /// <summary>
        /// The fallback templates used in the broadcast
        /// </summary>
        /// <value>The fallback templates used in the broadcast</value>
        [JsonPropertyName("fallback_templates")]
        public List<FallbackTemplate>? FallbackTemplates { get; set; }

        /// <summary>
        /// The creation timestamp of the broadcast
        /// </summary>
        /// <value>The creation timestamp of the broadcast</value>
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The last updated timestamp of the broadcast
        /// </summary>
        /// <value>The last updated timestamp of the broadcast</value>
        [JsonPropertyName("last_updated")]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// The scheduled time for the broadcast
        /// </summary>
        /// <value>The scheduled time for the broadcast</value>
        [JsonPropertyName("scheduled_at")]
        public DateTime ScheduledAt { get; set; }

        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [JsonPropertyName("statistics")]
        public BroadcastStatistics Statistics { get; set; }
    }
}
