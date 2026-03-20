using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for scheduling template messages.
    /// </summary>
    [DataContract(Name = "ScheduleTemplateMessagesRequest")]
    public class ScheduleTemplateMessagesRequest {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTemplateMessagesRequest" /> class.
        /// </summary>
        /// <param name="channel">The channel name or number from which the template messages will be sent (null for default channel).</param>
        /// <param name="templateName">The name of the template to be used for sending messages. (required).</param>
        /// <param name="broadcastName">The name of the broadcast to be created. (required).</param>
        /// <param name="scheduledAt">The scheduled time to send the template messages in UTC. (required).</param>
        /// <param name="recipients">List of recipients to send the template message to. (1 to 10,000 items) (required).</param>
        public ScheduleTemplateMessagesRequest(string? channel = null, string? templateName = null, string? broadcastName = default, DateTime scheduledAt = default, List<TemplateMessageRecipient>? recipients = null) {
            this.Channel = channel;
            this.TemplateName = templateName ?? throw new ArgumentNullException(nameof(templateName));
            this.BroadcastName = broadcastName ?? throw new ArgumentNullException(nameof(broadcastName));
            this.ScheduledAt = scheduledAt;
            this.Recipients = recipients ?? throw new ArgumentNullException(nameof(recipients));
        }

        /// <summary>
        /// The channel name or number from which the template messages will be sent (null for default channel).
        /// </summary>
        [JsonPropertyName("channel")]
        public string? Channel { get; set; }
        /// <summary>
        /// The name of the template to be used for sending messages.
        /// </summary>
        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }
        /// <summary>
        /// The name of the broadcast to be created.
        /// </summary>
        [JsonPropertyName("broadcast_name")]
        public string BroadcastName { get; set; }
        /// <summary>
        /// The scheduled time to send the template messages in UTC.
        /// </summary>
        [JsonPropertyName("scheduled_at")]
        public DateTime ScheduledAt { get; set; }
        /// <summary>
        /// List of recipients to send the template message to. (1 to 10,000 items)
        /// </summary>
        [JsonPropertyName("recipients")]
        public List<TemplateMessageRecipient> Recipients { get; set; }
    }
}
