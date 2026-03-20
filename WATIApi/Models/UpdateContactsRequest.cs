using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for updating contacts.
    /// </summary>
    [DataContract(Name = "UpdateContactsRequest")]
    public class UpdateContactsRequest {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactsRequest" /> class.
        /// </summary>
        /// <param name="contacts">List of contacts to update. (required).</param>
        public UpdateContactsRequest(List<UpdateContactRequest> contacts) {
            this.Contacts = contacts ?? throw new ArgumentNullException("contacts is a required property for UpdateContactsRequest and cannot be null");
        }

        /// <summary>
        /// List of contacts to update.
        /// </summary>
        [JsonPropertyName("contacts")]
        public List<UpdateContactRequest> Contacts { get; set; }
    }
}
