using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents the result of sending template messages to recipients.
    /// </summary>
    [DataContract(Name = "SendTemplateMessagesResponse")]
    public partial class SendTemplateMessagesResponse {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendTemplateMessagesResponse" /> class.
        /// </summary>
        /// <param name="success">Indicates whether the operation was successful..</param>
        /// <param name="broadcastID">The ID of the created broadcast..</param>
        /// <param name="error">An error message, if any..</param>
        /// <param name="recipients">A list of results for each recipient..</param>
        public SendTemplateMessagesResponse(bool success = default, string? broadcastID = null, string? error = null, List<TemplateMessageRecipientResult>? recipients = null) {
            this.Success = success;
            this.BroadcastID = broadcastID;
            this.Error = error;
            this.Recipients = recipients;
        }

        /// <summary>
        /// Indicates whether the operation was successful.
        /// </summary>
        /// <value>Indicates whether the operation was successful.</value>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// The ID of the created broadcast.
        /// </summary>
        /// <value>The ID of the created broadcast.</value>
        [JsonPropertyName("broadcast_id")]
        public string? BroadcastID { get; set; }

        /// <summary>
        /// An error message, if any.
        /// </summary>
        /// <value>An error message, if any.</value>
        [JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// A list of results for each recipient.
        /// </summary>
        /// <value>A list of results for each recipient.</value>
        [JsonPropertyName("recipients")]
        public List<TemplateMessageRecipientResult>? Recipients { get; set; }
    }
}
