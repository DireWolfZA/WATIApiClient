using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for sending template messages.
    /// </summary>
    [DataContract(Name = "SendTemplateMessagesRequest")]
    public class SendTemplateMessagesRequest {
        /// <summary>
        /// The channel name or number from which the template messages will be sent (null for default channel).
        /// </summary>
        [JsonPropertyName("channel")]
        public string? Channel { get; set; }
        /// <summary>
        /// The name of the template to be used for sending messages.
        /// </summary>
        [JsonPropertyName("template_name")]
        public required string TemplateName { get; set; }
        /// <summary>
        /// The name of the broadcast to be created.
        /// </summary>
        [JsonPropertyName("broadcast_name")]
        public required string BroadcastName { get; set; }
        /// <summary>
        /// List of recipients to send the template message to. (1 to 10,000 items)
        /// </summary>
        [JsonPropertyName("recipients")]
        public required List<TemplateMessageRecipient> Recipients { get; set; }
    }
}
