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
        /// Initializes a new instance of the <see cref="UpdateContactsResponse" /> class.
        /// </summary>
        /// <param name="contactList">The list of contact.</param>
        public UpdateContactsResponse(List<Contact> contactList) {
            this.ContactList = contactList;
        }

        /// <summary>
        /// The list of contact.
        /// </summary>
        [JsonPropertyName("contact_list")]
        public List<Contact> ContactList { get; set; }
    }
}
