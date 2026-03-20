using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for sending a text message.
    /// </summary>
    [DataContract(Name = "SendTextResponse")]
    public class SendTextResponse {
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [JsonPropertyName("message")]
        public required ConversationEvent Message { get; set; }
    }
}
