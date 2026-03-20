using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for starting a chatbot.
    /// </summary>
    [DataContract(Name = "StartChatbotResponse")]
    public class StartChatbotResponse {
        /// <summary>
        /// Result of the chatbot start operation.
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
