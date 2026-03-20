using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for sending an interactive message.
    /// </summary>
    [DataContract(Name = "SendInteractiveMessageResponse")]
    public class SendInteractiveMessageResponse {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendInteractiveMessageResponse" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        public SendInteractiveMessageResponse(Message message) {
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [JsonPropertyName("message")]
        public Message Message { get; set; }
    }
}
