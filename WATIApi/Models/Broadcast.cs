using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a broadcast object.
    /// </summary>
    [DataContract(Name = "BroadcastDto")]
    public class Broadcast {
        /// <summary>
        /// Initializes a new instance of the <see cref="Broadcast" /> class.
        /// </summary>
        /// <param name="id">The identifier of the broadcast.</param>
        /// <param name="channelId">The identifier of the channel associated with the broadcast.</param>
        /// <param name="name">The name of the broadcast.</param>
        /// <param name="status">The status of the broadcast.</param>
        /// <param name="templateId">The identifier of the message template used in the broadcast.</param>
        /// <param name="fallbackTemplates">The fallback templates used in the broadcast.</param>
        /// <param name="created">The creation timestamp of the broadcast.</param>
        /// <param name="lastUpdated">The last updated timestamp of the broadcast.</param>
        /// <param name="scheduledAt">The scheduled time for the broadcast.</param>
        public Broadcast(string? id = null, string? channelId = null, string? name = null, string? status = null, string? templateId = null, List<FallbackTemplate>? fallbackTemplates = null, DateTime created = default, DateTime lastUpdated = default, DateTime scheduledAt = default) {
            this.ID = id;
            this.ChannelID = channelId;
            this.Name = name;
            this.Status = status;
            this.TemplateID = templateId;
            this.FallbackTemplates = fallbackTemplates;
            this.Created = created;
            this.LastUpdated = lastUpdated;
            this.ScheduledAt = scheduledAt;
        }

        /// <summary>
        /// The identifier of the broadcast
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// The identifier of the channel associated with the broadcast
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string? ChannelID { get; set; }
        /// <summary>
        /// The name of the broadcast
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// The status of the broadcast
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        /// <summary>
        /// The identifier of the message template used in the broadcast
        /// </summary>
        [JsonPropertyName("template_id")]
        public string? TemplateID { get; set; }
        /// <summary>
        /// The fallback templates used in the broadcast
        /// </summary>
        [JsonPropertyName("fallback_templates")]
        public List<FallbackTemplate>? FallbackTemplates { get; set; }
        /// <summary>
        /// The creation timestamp of the broadcast
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }
        /// <summary>
        /// The last updated timestamp of the broadcast
        /// </summary>
        [JsonPropertyName("last_updated")]
        public DateTime LastUpdated { get; set; }
        /// <summary>
        /// The scheduled time for the broadcast
        /// </summary>
        [JsonPropertyName("scheduled_at")]
        public DateTime ScheduledAt { get; set; }
    }
}
