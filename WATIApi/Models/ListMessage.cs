using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a list type message in a conversation.
    /// </summary>
    [DataContract(Name = "ListMessageDto")]
    public class ListMessage {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMessage" /> class.
        /// </summary>
        /// <param name="header">header.</param>
        /// <param name="body">body.</param>
        /// <param name="footer">footer.</param>
        /// <param name="buttonText">buttonText.</param>
        /// <param name="sections">sections.</param>
        public ListMessage(string? header = null, string? body = null, string? footer = null, string? buttonText = null, List<ListMessageSection>? sections = null) {
            this.Header = header;
            this.Body = body ?? throw new ArgumentNullException(nameof(body));
            this.Footer = footer;
            this.ButtonText = buttonText;
            this.Sections = sections ?? throw new ArgumentNullException(nameof(sections));
        }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [JsonPropertyName("header")]
        public string? Header { get; set; }
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }
        /// <summary>
        /// Gets or Sets Footer
        /// </summary>
        [JsonPropertyName("footer")]
        public string? Footer { get; set; }
        /// <summary>
        /// Gets or Sets ButtonText
        /// </summary>
        [JsonPropertyName("button_text")]
        public string? ButtonText { get; set; }
        /// <summary>
        /// Gets or Sets Sections
        /// </summary>
        [JsonPropertyName("sections")]
        public List<ListMessageSection> Sections { get; set; }
    }
}
