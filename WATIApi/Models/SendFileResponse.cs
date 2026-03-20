using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for sending a file message.
    /// </summary>
    [DataContract(Name = "SendFileResponse")]
    public class SendFileResponse {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendFileResponse" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        public SendFileResponse(Message message) {
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [JsonPropertyName("message")]
        public Message Message { get; set; }
    }
}
