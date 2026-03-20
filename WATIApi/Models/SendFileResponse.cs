using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for sending a file message.
    /// </summary>
    [DataContract(Name = "SendFileResponse")]
    public class SendFileResponse {
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [JsonPropertyName("message")]
        public required Message Message { get; set; }
    }
}
