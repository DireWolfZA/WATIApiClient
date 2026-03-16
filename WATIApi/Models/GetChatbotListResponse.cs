using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting the chatbot list.
    /// </summary>
    [DataContract(Name = "GetChatbotListResponse")]
    public partial class GetChatbotListResponse {
        /// <summary>
        /// The list of chatbot.
        /// </summary>
        /// <value>The list of chatbot.</value>
        [JsonPropertyName("chatbot_list")]
        public List<Chatbot>? ChatbotList { get; set; }

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
