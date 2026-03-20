using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents an interactive message.
    /// </summary>
    [DataContract(Name = "SendInteractiveMessageRequest")]
    public class SendInteractiveMessageRequest {
        /// <summary>
        /// The target recipient in the following formats:
        /// <br />* &#x60;ConversationID&#x60;: The unique ID of a conversation.
        /// <br />* &#x60;PhoneNumber&#x60;: The recipient&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </summary>
        [JsonPropertyName("target")]
        public required string Target { get; set; }
        /// <summary>
        /// Message type: &quot;buttons&quot; or &quot;list&quot;.
        /// </summary>
        [JsonPropertyName("type")]
        public required string Type { get; set; }
        /// <summary>
        /// Represents a message with buttons in a conversation.
        /// </summary>
        [JsonPropertyName("button_message")]
        public ButtonsMessage? ButtonMessage { get; set; }
        /// <summary>
        /// Represents a list type message in a conversation.
        /// </summary>
        [JsonPropertyName("list_message")]
        public ListMessage? ListMessage { get; set; }
    }
}
