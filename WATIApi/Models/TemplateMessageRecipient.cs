using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// DTO representing a recipient for a template message, including their phone number and custom parameters.
    /// </summary>
    [DataContract(Name = "TemplateMessageRecipientDto")]
    public partial class TemplateMessageRecipient {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateMessageRecipient" /> class.
        /// </summary>
        /// <param name="phoneNumber">The recipient&#39;s phone number. (required).</param>
        /// <param name="localMessageID">The local message identifier..</param>
        /// <param name="customParams">A list of custom parameters to be used in the template message..</param>
        public TemplateMessageRecipient(string phoneNumber, string? localMessageID = null, List<TemplateParameter>? customParams = null) {
            this.PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
            this.LocalMessageID = localMessageID;
            this.CustomParams = customParams;
        }

        /// <summary>
        /// The recipient&#39;s phone number.
        /// </summary>
        /// <value>The recipient&#39;s phone number.</value>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// The local message identifier.
        /// </summary>
        /// <value>The local message identifier.</value>
        [JsonPropertyName("local_message_id")]
        public string? LocalMessageID { get; set; }

        /// <summary>
        /// A list of custom parameters to be used in the template message.
        /// </summary>
        /// <value>A list of custom parameters to be used in the template message.</value>
        [JsonPropertyName("custom_params")]
        public List<TemplateParameter>? CustomParams { get; set; }
    }
}
