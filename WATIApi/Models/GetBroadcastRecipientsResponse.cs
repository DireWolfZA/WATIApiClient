using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting the recipients of a specific broadcast.
    /// </summary>
    [DataContract(Name = "GetBroadcastRecipientsResponse")]
    public class GetBroadcastRecipientsResponse {
        /// <summary>
        /// The list of broadcast recipients
        /// </summary>
        [JsonPropertyName("recipients")]
        public List<BroadcastRecipient>? Recipients { get; set; }
        /// <summary>
        /// The current page number
        /// </summary>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }
        /// <summary>
        /// The number of items per page
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// The total number of recipients
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
