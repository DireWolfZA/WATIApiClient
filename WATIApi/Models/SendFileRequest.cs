using System;
using System.Runtime.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for sending a file message.
    /// </summary>
    [DataContract(Name = "SendFileRequest")]
    public class SendFileRequest {
        /// <summary>
        /// The target conversation in the following formats:
        /// <br />* &#x60;ConversationID&#x60;: The unique ID of a conversation.
        /// <br />* &#x60;PhoneNumber&#x60;: The conversation&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </summary>
        public required string Target { get; set; }

        public required string FileName { get; set; }
        public required RestSharp.ContentType ContentType { get; set; }
        /// <summary>
        /// File to send. <see href="https://support.wati.io/en/articles/11463010-supported-media-types-and-sizes-in-wati"/>
        /// </summary>
        public byte[]? FileContents { get; set; }
        /// <summary>
        /// File to send. <see href="https://support.wati.io/en/articles/11463010-supported-media-types-and-sizes-in-wati"/>
        /// </summary>
        public System.IO.Stream? FileStream { get; set; }
        /// <summary>
        /// Optional caption for the file.
        /// </summary>
        public string? Caption { get; set; }
    }
}
