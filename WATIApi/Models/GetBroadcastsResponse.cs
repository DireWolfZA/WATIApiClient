using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting broadcasts.
    /// </summary>
    [DataContract(Name = "GetBroadcastsResponse")]
    public class GetBroadcastsResponse {
        /// <summary>
        /// The list of broadcast info.
        /// </summary>
        [JsonPropertyName("broadcasts")]
        public List<Broadcast>? Broadcasts { get; set; }
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
        /// <summary>
        /// The total number of message templates available.
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
