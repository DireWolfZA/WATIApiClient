using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting contact list.
    /// </summary>
    [DataContract(Name = "GetContactListResponse")]
    public class GetContactListResponse {
        /// <summary>
        /// The list of message templates.
        /// </summary>
        [JsonPropertyName("contact_list")]
        public List<Contact>? ContactList { get; set; }
        /// <summary>
        /// The current page number.
        /// </summary>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }
        /// <summary>
        /// The number of items per page.
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }
    }
}
