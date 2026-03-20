using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a broadcast recipient.
    /// </summary>
    [DataContract(Name = "BroadcastRecipientDto")]
    public class BroadcastRecipient {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastRecipient" /> class.
        /// </summary>
        /// <param name="id">The identifier of the broadcast recipient.</param>
        /// <param name="contactID">The identifier of the contact associated with the recipient.</param>
        /// <param name="contactName">The name of the contact.</param>
        /// <param name="contactPhone">The phone number of the contact.</param>
        /// <param name="status">The status of the broadcast recipient.</param>
        /// <param name="failedCode">The failure code if the message failed to send.</param>
        /// <param name="localMessageID">The local message identifier.</param>
        /// <param name="messageID">The message identifier from the messaging platform.</param>
        /// <param name="customParams">The custom parameters associated with the recipient.</param>
        /// <param name="created">The creation timestamp of the broadcast recipient.</param>
        public BroadcastRecipient(string? id = null, string? contactID = null, string? contactName = null, string? contactPhone = null, string? status = null, string? failedCode = null, string? localMessageID = null, string? messageID = null, List<CustomParam>? customParams = null, DateTime created = default) {
            this.ID = id;
            this.ContactID = contactID;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
            this.Status = status;
            this.FailedCode = failedCode;
            this.LocalMessageID = localMessageID;
            this.MessageID = messageID;
            this.CustomParams = customParams;
            this.Created = created;
        }

        /// <summary>
        /// The identifier of the broadcast recipient
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// The identifier of the contact associated with the recipient
        /// </summary>
        [JsonPropertyName("contact_id")]
        public string? ContactID { get; set; }
        /// <summary>
        /// The name of the contact
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string? ContactName { get; set; }
        /// <summary>
        /// The phone number of the contact
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string? ContactPhone { get; set; }
        /// <summary>
        /// The status of the broadcast recipient
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        /// <summary>
        /// The failure code if the message failed to send
        /// </summary>
        [JsonPropertyName("failed_code")]
        public string? FailedCode { get; set; }
        /// <summary>
        /// The local message identifier
        /// </summary>
        [JsonPropertyName("local_message_id")]
        public string? LocalMessageID { get; set; }
        /// <summary>
        /// The message identifier from the messaging platform
        /// </summary>
        [JsonPropertyName("message_id")]
        public string? MessageID { get; set; }
        /// <summary>
        /// The custom parameters associated with the recipient
        /// </summary>
        [JsonPropertyName("custom_params")]
        public List<CustomParam>? CustomParams { get; set; }
        /// <summary>
        /// The creation timestamp of the broadcast recipient
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }
    }
}
