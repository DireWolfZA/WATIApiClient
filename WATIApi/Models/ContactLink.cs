using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents linked contact information across different messaging platforms.
    /// </summary>
    [DataContract(Name = "ContactLinkDto")]
    public class ContactLink {
        /// <summary>
        /// The contact identifier for WhatsApp.
        /// </summary>
        [JsonPropertyName("whats_app_contact_id")]
        public string? WhatsAppContactID { get; set; }
        /// <summary>
        /// The contact identifier for Instagram.
        /// </summary>
        [JsonPropertyName("instagram_contact_id")]
        public string? InstagramContactID { get; set; }
        /// <summary>
        /// The contact identifier for Messenger.
        /// </summary>
        [JsonPropertyName("messenger_contact_id")]
        public string? MessengerContactID { get; set; }
    }
}
