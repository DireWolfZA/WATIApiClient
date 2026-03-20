using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting the message list.
    /// </summary>
    [DataContract(Name = "GetMessagesByConversationIdResponse")]
    public class GetMessagesByConversationIDResponse {
        /// <summary>
        /// The list of conversation message
        /// </summary>
        [JsonPropertyName("message_list")]
        public List<ConversationEvent>? MessageList { get; set; }
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
