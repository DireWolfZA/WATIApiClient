using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents linked contact information across different messaging platforms.
    /// </summary>
    [DataContract(Name = "ContactLinkDto")]
    public partial class ContactLink {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactLink" /> class.
        /// </summary>
        /// <param name="whatsAppContactID">The contact identifier for WhatsApp..</param>
        /// <param name="instagramContactID">The contact identifier for Instagram..</param>
        /// <param name="messengerContactID">The contact identifier for Messenger..</param>
        public ContactLink(string? whatsAppContactID = null, string? instagramContactID = null, string? messengerContactID = null) {
            this.WhatsAppContactID = whatsAppContactID;
            this.InstagramContactID = instagramContactID;
            this.MessengerContactID = messengerContactID;
        }

        /// <summary>
        /// The contact identifier for WhatsApp.
        /// </summary>
        /// <value>The contact identifier for WhatsApp.</value>
        [JsonPropertyName("whats_app_contact_id")]
        public string? WhatsAppContactID { get; set; }

        /// <summary>
        /// The contact identifier for Instagram.
        /// </summary>
        /// <value>The contact identifier for Instagram.</value>
        [JsonPropertyName("instagram_contact_id")]
        public string? InstagramContactID { get; set; }

        /// <summary>
        /// The contact identifier for Messenger.
        /// </summary>
        /// <value>The contact identifier for Messenger.</value>
        [JsonPropertyName("messenger_contact_id")]
        public string? MessengerContactID { get; set; }
    }
}
