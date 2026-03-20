using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a contact object.
    /// </summary>
    [DataContract(Name = "ContactDto")]
    public class Contact {
        /// <summary>
        /// Unique identifier for the contact.
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// WhatsApp identifier for the contact.
        /// </summary>
        [JsonPropertyName("wa_id")]
        public string? WA_ID { get; set; }
        /// <summary>
        /// The contact&#39;s name.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// The contact&#39;s phone number.
        /// </summary>
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }
        /// <summary>
        /// URL or path to the contact&#39;s photo.
        /// </summary>
        [JsonPropertyName("photo")]
        public string? Photo { get; set; }
        /// <summary>
        /// The date and time when the contact was created.
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }
        /// <summary>
        /// The date and time when the contact was last updated.
        /// </summary>
        [JsonPropertyName("last_updated")]
        public DateTime LastUpdated { get; set; }
        /// <summary>
        /// The current status of the contact.
        /// </summary>
        [JsonPropertyName("contact_status")]
        public string? ContactStatus { get; set; }
        /// <summary>
        /// The source where the contact originated from.
        /// </summary>
        [JsonPropertyName("source")]
        public string? Source { get; set; }
        /// <summary>
        /// The identifier of the channel associated with the contact.
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string? ChannelID { get; set; }
        /// <summary>
        /// Instagram phone source information.
        /// </summary>
        [JsonPropertyName("ig_phone_source")]
        public string? IGPhoneSource { get; set; }
        /// <summary>
        /// Messenger phone source information.
        /// </summary>
        [JsonPropertyName("mg_phone_source")]
        public string? MGPhoneSource { get; set; }
        /// <summary>
        /// Indicates whether the contact has opted in for communications.
        /// </summary>
        [JsonPropertyName("opted_in")]
        public bool OptedIn { get; set; }
        /// <summary>
        /// Indicates whether the contact allows broadcast messages.
        /// </summary>
        [JsonPropertyName("allow_broadcast")]
        public bool AllowBroadcast { get; set; }
        /// <summary>
        /// Indicates whether the contact allows SMS messages.
        /// </summary>
        [JsonPropertyName("allow_sms")]
        public bool AllowSMS { get; set; }
        /// <summary>
        /// List of team associated with the contact.
        /// </summary>
        [JsonPropertyName("teams")]
        public List<string>? Teams { get; set; }
        /// <summary>
        /// List of segments the contact belongs to.
        /// </summary>
        [JsonPropertyName("segments")]
        public List<string>? Segments { get; set; }
        /// <summary>
        /// List of custom parameters associated with the contact.
        /// </summary>
        [JsonPropertyName("custom_params")]
        public List<CustomParam>? CustomParams { get; set; }
        /// <summary>
        /// The type of channel (e.g., whatsapp, instagram, messenger).
        /// </summary>
        [JsonPropertyName("channel_type")]
        public string? ChannelType { get; set; }
        /// <summary>
        /// The display name for the contact.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Represents linked contact information across different messaging platforms.
        /// </summary>
        [JsonPropertyName("contact_link")]
        public ContactLink? ContactLink { get; set; }
        /// <summary>
        /// Indicates whether the broadcast limit has been reached for this contact.
        /// </summary>
        [JsonPropertyName("is_broadcast_limit_reached")]
        public string? IsBroadcastLimitReached { get; set; }
    }
}
