using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for sending a text message.
    /// </summary>
    [DataContract(Name = "SendTextRequest")]
    public class SendTextRequest {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendTextRequest" /> class.
        /// </summary>
        /// <param name="target">
        /// The target conversation in the following formats:
        /// <br />* &#x60;ConversationID&#x60;: The unique ID of a conversation.
        /// <br />* &#x60;PhoneNumber&#x60;: The recipient&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </param>
        /// <param name="text">Message content. (required).</param>
        public SendTextRequest(string target, string text) {
            this.Target = target ?? throw new ArgumentNullException(nameof(target));
            this.Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// The target conversation in the following formats:
        /// <br />* &#x60;ConversationID&#x60;: The unique ID of a conversation.
        /// <br />* &#x60;PhoneNumber&#x60;: The recipient&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; }
        /// <summary>
        /// Message content.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
