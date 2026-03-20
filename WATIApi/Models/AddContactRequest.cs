using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for adding a new contact.
    /// </summary>
    [DataContract(Name = "AddContactRequest")]
    public class AddContactRequest {
        public AddContactRequest(string whatsAppNumber, string name) {
            WhatsAppNumber = whatsAppNumber;
            Name = name;
        }

        /// <summary>
        /// The WhatsApp number of the contact to be added.
        /// </summary>
        [JsonPropertyName("whatsapp_number")]
        public string WhatsAppNumber { get; set; }
        /// <summary>
        /// The name of the contact.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
