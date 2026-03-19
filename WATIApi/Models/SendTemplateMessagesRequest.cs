using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for sending template messages.
    /// </summary>
    [DataContract(Name = "SendTemplateMessagesRequest")]
    public partial class SendTemplateMessagesRequest {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendTemplateMessagesRequest" /> class.
        /// </summary>
        /// <param name="channel">The channel name or number from which the template messages will be sent (null for default channel)..</param>
        /// <param name="templateName">The name of the template to be used for sending messages. (required).</param>
        /// <param name="broadcastName">The name of the broadcast to be created. (required).</param>
        /// <param name="recipients">List of recipients to send the template message to. (1 to 10,000 items) (required).</param>
        public SendTemplateMessagesRequest(string? channel = null, string? templateName = null, string? broadcastName = null, List<TemplateMessageRecipient>? recipients = null) {
            this.Channel = channel;
            this.TemplateName = templateName ?? throw new ArgumentNullException(nameof(templateName));
            this.BroadcastName = broadcastName ?? throw new ArgumentNullException(nameof(broadcastName));
            this.Recipients = recipients ?? throw new ArgumentNullException(nameof(recipients));
        }

        /// <summary>
        /// The channel name or number from which the template messages will be sent (null for default channel).
        /// </summary>
        /// <value>The channel name or number from which the template messages will be sent (null for default channel).</value>
        [JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// The name of the template to be used for sending messages.
        /// </summary>
        /// <value>The name of the template to be used for sending messages.</value>
        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// The name of the broadcast to be created.
        /// </summary>
        /// <value>The name of the broadcast to be created.</value>
        [JsonPropertyName("broadcast_name")]
        public string BroadcastName { get; set; }

        /// <summary>
        /// List of recipients to send the template message to. (1 to 10,000 items)
        /// </summary>
        /// <value>List of recipients to send the template message to. (1 to 10,000 items)</value>
        [JsonPropertyName("recipients")]
        public List<TemplateMessageRecipient> Recipients { get; set; }
    }
}
