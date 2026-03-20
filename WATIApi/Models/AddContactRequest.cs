using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for adding a new contact.
    /// </summary>
    [DataContract(Name = "AddContactRequest")]
    public class AddContactRequest {
        /// <summary>
        /// The WhatsApp number of the contact to be added.
        /// </summary>
        [JsonPropertyName("whatsapp_number")]
        public required string WhatsAppNumber { get; set; }
        /// <summary>
        /// The name of the contact.
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; set; }
    }
}
