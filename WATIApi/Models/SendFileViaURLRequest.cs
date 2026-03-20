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
        /// Initializes a new instance of the <see cref="SendFileViaURLRequest" /> class.
        /// </summary>
        /// <param name="target">
        /// The target conversation in the following formats:
        /// <br />* &#x60;ConversationID&#x60;: The unique ID of a conversation.
        /// <br />* &#x60;PhoneNumber&#x60;: The conversation&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </param>
        /// <param name="fileUrl">File to send. (required).</param>
        /// <param name="caption">Optional caption for the file.</param>
        public SendFileViaURLRequest(string target, string fileUrl, string? caption = null) {
            this.Target = target ?? throw new ArgumentNullException(nameof(target));
            this.FileURL = fileUrl ?? throw new ArgumentNullException(nameof(fileUrl));
            this.Caption = caption;
        }

        /// <summary>
        /// The target conversation in the following formats:
        /// <br />* &#x60;ConversationID&#x60;: The unique ID of a conversation.
        /// <br />* &#x60;PhoneNumber&#x60;: The conversation&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; }
        /// <summary>
        /// File to send.
        /// </summary>
        [JsonPropertyName("file_url")]
        public string FileURL { get; set; }
        /// <summary>
        /// Optional caption for the file.
        /// </summary>
        [JsonPropertyName("caption")]
        public string? Caption { get; set; }
    }
}
