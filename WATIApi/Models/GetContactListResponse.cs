using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting contact list.
    /// </summary>
    [DataContract(Name = "GetContactListResponse")]
    public partial class GetContactListResponse {
        /// <summary>
        /// The list of message templates.
        /// </summary>
        /// <value>The list of message templates.</value>
        [JsonPropertyName("contact_list")]
        public List<Contact>? ContactList { get; set; }

        /// <summary>
        /// The current page number.
        /// </summary>
        /// <value>The current page number.</value>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        /// <summary>
        /// The number of items per page.
        /// </summary>
        /// <value>The number of items per page.</value>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }
    }
}
