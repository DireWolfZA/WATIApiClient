using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting broadcasts.
    /// </summary>
    [DataContract(Name = "GetBroadcastsResponse")]
    public partial class GetBroadcastsResponse {
        /// <summary>
        /// The list of broadcast info.
        /// </summary>
        /// <value>The list of broadcast info.</value>
        [JsonPropertyName("broadcasts")]
        public List<Broadcast>? Broadcasts { get; set; }

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

        /// <summary>
        /// The total number of message templates available.
        /// </summary>
        /// <value>The total number of message templates available.</value>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
