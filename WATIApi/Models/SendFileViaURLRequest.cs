using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for sending a file message.
    /// </summary>
    [DataContract(Name = "SendFileViaUrlRequest")]
    public class SendFileViaURLRequest {
        /// <summary>
        /// The target conversation in the following formats:
        /// <br />* &#x60;ConversationID&#x60;: The unique ID of a conversation.
        /// <br />* &#x60;PhoneNumber&#x60;: The conversation&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </summary>
        [JsonPropertyName("target")]
        public required string Target { get; set; }
        /// <summary>
        /// File to send.
        /// </summary>
        [JsonPropertyName("file_url")]
        public required string FileURL { get; set; }
        /// <summary>
        /// Optional caption for the file.
        /// </summary>
        [JsonPropertyName("caption")]
        public string? Caption { get; set; }
    }
}
