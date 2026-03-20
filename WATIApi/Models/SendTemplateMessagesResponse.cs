using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents the result of sending template messages to recipients.
    /// </summary>
    [DataContract(Name = "SendTemplateMessagesResponse")]
    public class SendTemplateMessagesResponse {
        /// <summary>
        /// Indicates whether the operation was successful.
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        /// <summary>
        /// The ID of the created broadcast.
        /// </summary>
        [JsonPropertyName("broadcast_id")]
        public string? BroadcastID { get; set; }
        /// <summary>
        /// An error message, if any.
        /// </summary>
        [JsonPropertyName("error")]
        public string? Error { get; set; }
        /// <summary>
        /// A list of results for each recipient.
        /// </summary>
        [JsonPropertyName("recipients")]
        public List<TemplateMessageRecipientResult>? Recipients { get; set; }
    }
}
