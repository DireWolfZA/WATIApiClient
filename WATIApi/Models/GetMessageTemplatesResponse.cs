using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting message templates.
    /// </summary>
    [DataContract(Name = "GetMessageTemplatesResponse")]
    public partial class GetMessageTemplatesResponse {
        /// <summary>
        /// The list of message templates.
        /// </summary>
        /// <value>The list of message templates.</value>
        [JsonPropertyName("templates")]
        public List<MessageTemplate>? Templates { get; set; }

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
