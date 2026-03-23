using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// DTO representing a recipient for a template message, including their phone number and custom parameters.
    /// </summary>
    [DataContract(Name = "TemplateMessageRecipientDto")]
    public class TemplateMessageRecipient {
        /// <summary>
        /// The recipient&#39;s phone number.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// The local message identifier.
        /// </summary>
        [JsonPropertyName("local_message_id")]
        public string? LocalMessageID { get; set; }
        /// <summary>
        /// A list of custom parameters to be used in the template message.
        /// </summary>
        [JsonPropertyName("custom_params")]
        public List<TemplateParameter>? CustomParams { get; set; }
    }
}
