using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// DTO representing the result of sending a template message to a recipient.
    /// </summary>
    [DataContract(Name = "TemplateMessageRecipientResultDto")]
    public partial class TemplateMessageRecipientResult {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateMessageRecipientResult" /> class.
        /// </summary>
        /// <param name="localMessageID">The local message identifier..</param>
        /// <param name="phoneNumber">The recipient&#39;s phone number..</param>
        /// <param name="errors">A list of errors encountered while sending the message, if any..</param>
        public TemplateMessageRecipientResult(string? localMessageID = null, string? phoneNumber = null, List<string>? errors = null) {
            this.LocalMessageID = localMessageID;
            this.PhoneNumber = phoneNumber;
            this.Errors = errors;
        }

        /// <summary>
        /// The local message identifier.
        /// </summary>
        /// <value>The local message identifier.</value>
        [JsonPropertyName("local_message_id")]
        public string? LocalMessageID { get; set; }

        /// <summary>
        /// The recipient&#39;s phone number.
        /// </summary>
        /// <value>The recipient&#39;s phone number.</value>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// A list of errors encountered while sending the message, if any.
        /// </summary>
        /// <value>A list of errors encountered while sending the message, if any.</value>
        [JsonPropertyName("errors")]
        public List<string>? Errors { get; set; }
    }
}
