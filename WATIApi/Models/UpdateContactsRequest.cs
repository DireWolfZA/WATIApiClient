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
        /// List of contacts to update.
        /// </summary>
        [JsonPropertyName("contacts")]
        public required List<UpdateContactRequest> Contacts { get; set; }
    }
}
