using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting updated contacts.
    /// </summary>
    [DataContract(Name = "UpdateContactsResponse")]
    public class UpdateContactsResponse {
        /// <summary>
        /// The list of contact.
        /// </summary>
        [JsonPropertyName("contact_list")]
        public required List<Contact> ContactList { get; set; }
    }
}
