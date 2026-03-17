using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for sending a text message.
    /// </summary>
    [DataContract(Name = "SendTextResponse")]
    public partial class SendTextResponse {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendTextResponse" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        public SendTextResponse(ConversationEvent message) {
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [JsonPropertyName("message")]
        public ConversationEvent Message { get; set; }
    }
}
