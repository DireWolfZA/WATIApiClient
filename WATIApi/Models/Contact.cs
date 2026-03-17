using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a contact object.
    /// </summary>
    [DataContract(Name = "ContactDto")]
    public partial class Contact {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="id">Unique identifier for the contact..</param>
        /// <param name="wa_id">WhatsApp identifier for the contact..</param>
        /// <param name="name">The contact&#39;s name..</param>
        /// <param name="phone">The contact&#39;s phone number..</param>
        /// <param name="photo">URL or path to the contact&#39;s photo..</param>
        /// <param name="created">The date and time when the contact was created..</param>
        /// <param name="lastUpdated">The date and time when the contact was last updated..</param>
        /// <param name="contactStatus">The current status of the contact..</param>
        /// <param name="source">The source where the contact originated from..</param>
        /// <param name="channelID">The identifier of the channel associated with the contact..</param>
        /// <param name="igPhoneSource">Instagram phone source information..</param>
        /// <param name="mgPhoneSource">Messenger phone source information..</param>
        /// <param name="optedIn">Indicates whether the contact has opted in for communications..</param>
        /// <param name="allowBroadcast">Indicates whether the contact allows broadcast messages..</param>
        /// <param name="allowSms">Indicates whether the contact allows SMS messages..</param>
        /// <param name="teams">List of team associated with the contact..</param>
        /// <param name="segments">List of segments the contact belongs to..</param>
        /// <param name="customParams">List of custom parameters associated with the contact..</param>
        /// <param name="channelType">The type of channel (e.g., whatsapp, instagram, messenger)..</param>
        /// <param name="displayName">The display name for the contact..</param>
        /// <param name="contactLink">Represents linked contact information across different messaging platforms..</param>
        /// <param name="isBroadcastLimitReached">Indicates whether the broadcast limit has been reached for this contact..</param>
        public Contact(string? id = null, string? wa_id = null, string? name = null, string? phone = null, string? photo = null, DateTime created = default, DateTime lastUpdated = default, string? contactStatus = null, string? source = null, string? channelID = null, string? igPhoneSource = null, string? mgPhoneSource = null, bool optedIn = default, bool allowBroadcast = default, bool allowSms = default, List<string>? teams = null, List<string>? segments = null, List<CustomParam>? customParams = null, string? channelType = null, string? displayName = null, ContactLink? contactLink = null, string? isBroadcastLimitReached = null) {
            this.ID = id;
            this.WA_ID = wa_id;
            this.Name = name;
            this.Phone = phone;
            this.Photo = photo;
            this.Created = created;
            this.LastUpdated = lastUpdated;
            this.ContactStatus = contactStatus;
            this.Source = source;
            this.ChannelID = channelID;
            this.IGPhoneSource = igPhoneSource;
            this.MGPhoneSource = mgPhoneSource;
            this.OptedIn = optedIn;
            this.AllowBroadcast = allowBroadcast;
            this.AllowSMS = allowSms;
            this.Teams = teams;
            this.Segments = segments;
            this.CustomParams = customParams;
            this.ChannelType = channelType;
            this.DisplayName = displayName;
            this.ContactLink = contactLink;
            this.IsBroadcastLimitReached = isBroadcastLimitReached;
        }

        /// <summary>
        /// Unique identifier for the contact.
        /// </summary>
        /// <value>Unique identifier for the contact.</value>
        [JsonPropertyName("id")]
        public string? ID { get; set; }

        /// <summary>
        /// WhatsApp identifier for the contact.
        /// </summary>
        /// <value>WhatsApp identifier for the contact.</value>
        [JsonPropertyName("wa_id")]
        public string? WA_ID { get; set; }

        /// <summary>
        /// The contact&#39;s name.
        /// </summary>
        /// <value>The contact&#39;s name.</value>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The contact&#39;s phone number.
        /// </summary>
        /// <value>The contact&#39;s phone number.</value>
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// URL or path to the contact&#39;s photo.
        /// </summary>
        /// <value>URL or path to the contact&#39;s photo.</value>
        [JsonPropertyName("photo")]
        public string? Photo { get; set; }

        /// <summary>
        /// The date and time when the contact was created.
        /// </summary>
        /// <value>The date and time when the contact was created.</value>
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The date and time when the contact was last updated.
        /// </summary>
        /// <value>The date and time when the contact was last updated.</value>
        [JsonPropertyName("last_updated")]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// The current status of the contact.
        /// </summary>
        /// <value>The current status of the contact.</value>
        [JsonPropertyName("contact_status")]
        public string? ContactStatus { get; set; }

        /// <summary>
        /// The source where the contact originated from.
        /// </summary>
        /// <value>The source where the contact originated from.</value>
        [JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The identifier of the channel associated with the contact.
        /// </summary>
        /// <value>The identifier of the channel associated with the contact.</value>
        [JsonPropertyName("channel_id")]
        public string? ChannelID { get; set; }

        /// <summary>
        /// Instagram phone source information.
        /// </summary>
        /// <value>Instagram phone source information.</value>
        [JsonPropertyName("ig_phone_source")]
        public string? IGPhoneSource { get; set; }

        /// <summary>
        /// Messenger phone source information.
        /// </summary>
        /// <value>Messenger phone source information.</value>
        [JsonPropertyName("mg_phone_source")]
        public string? MGPhoneSource { get; set; }

        /// <summary>
        /// Indicates whether the contact has opted in for communications.
        /// </summary>
        /// <value>Indicates whether the contact has opted in for communications.</value>
        [JsonPropertyName("opted_in")]
        public bool OptedIn { get; set; }

        /// <summary>
        /// Indicates whether the contact allows broadcast messages.
        /// </summary>
        /// <value>Indicates whether the contact allows broadcast messages.</value>
        [JsonPropertyName("allow_broadcast")]
        public bool AllowBroadcast { get; set; }

        /// <summary>
        /// Indicates whether the contact allows SMS messages.
        /// </summary>
        /// <value>Indicates whether the contact allows SMS messages.</value>
        [JsonPropertyName("allow_sms")]
        public bool AllowSMS { get; set; }

        /// <summary>
        /// List of team associated with the contact.
        /// </summary>
        /// <value>List of team associated with the contact.</value>
        [JsonPropertyName("teams")]
        public List<string>? Teams { get; set; }

        /// <summary>
        /// List of segments the contact belongs to.
        /// </summary>
        /// <value>List of segments the contact belongs to.</value>
        [JsonPropertyName("segments")]
        public List<string>? Segments { get; set; }

        /// <summary>
        /// List of custom parameters associated with the contact.
        /// </summary>
        /// <value>List of custom parameters associated with the contact.</value>
        [JsonPropertyName("custom_params")]
        public List<CustomParam>? CustomParams { get; set; }

        /// <summary>
        /// The type of channel (e.g., whatsapp, instagram, messenger).
        /// </summary>
        /// <value>The type of channel (e.g., whatsapp, instagram, messenger).</value>
        [JsonPropertyName("channel_type")]
        public string? ChannelType { get; set; }

        /// <summary>
        /// The display name for the contact.
        /// </summary>
        /// <value>The display name for the contact.</value>
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
        /// <value>Indicates whether the broadcast limit has been reached for this contact.</value>
        [JsonPropertyName("is_broadcast_limit_reached")]
        public string? IsBroadcastLimitReached { get; set; }
    }
}
