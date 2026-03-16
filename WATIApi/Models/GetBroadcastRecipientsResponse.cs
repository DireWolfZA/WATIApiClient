using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting the recipients of a specific broadcast.
    /// </summary>
    [DataContract(Name = "GetBroadcastRecipientsResponse")]
    public partial class GetBroadcastRecipientsResponse {
        /// <summary>
        /// The list of broadcast recipients
        /// </summary>
        /// <value>The list of broadcast recipients</value>
        [JsonPropertyName("recipients")]
        public List<BroadcastRecipient>? Recipients { get; set; }

        /// <summary>
        /// The current page number
        /// </summary>
        /// <value>The current page number</value>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        /// <summary>
        /// The number of items per page
        /// </summary>
        /// <value>The number of items per page</value>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// The total number of recipients
        /// </summary>
        /// <value>The total number of recipients</value>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
