using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for updating conversation status.
    /// </summary>
    [DataContract(Name = "UpdateConversationStatusRequest")]
    public class UpdateConversationStatusRequest {
        /// <summary>
        /// New status of the conversation:
        /// <br />* &#x60;open&#x60;: The conversation is open and active.
        /// <br />* &#x60;solved&#x60;: The conversation has been resolved.
        /// <br />* &#x60;pending&#x60;: The conversation is pending further action.
        /// <br />* &#x60;block&#x60;: The conversation is blocked.
        /// </summary>
        [JsonPropertyName("new_status")]
        public required string NewStatus { get; set; }
    }
}
