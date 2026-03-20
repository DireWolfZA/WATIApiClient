using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for sending an interactive message.
    /// </summary>
    [DataContract(Name = "SendInteractiveMessageResponse")]
    public class SendInteractiveMessageResponse {
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [JsonPropertyName("message")]
        public required Message Message { get; set; }
    }
}
