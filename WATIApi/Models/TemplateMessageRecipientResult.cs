using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// DTO representing the result of sending a template message to a recipient.
    /// </summary>
    [DataContract(Name = "TemplateMessageRecipientResultDto")]
    public class TemplateMessageRecipientResult {
        /// <summary>
        /// The local message identifier.
        /// </summary>
        [JsonPropertyName("local_message_id")]
        public string? LocalMessageID { get; set; }
        /// <summary>
        /// The recipient&#39;s phone number.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// A list of errors encountered while sending the message, if any.
        /// </summary>
        [JsonPropertyName("errors")]
        public List<string>? Errors { get; set; }
    }
}
