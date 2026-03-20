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
        /// Gets or Sets Header
        /// </summary>
        [JsonPropertyName("header")]
        public string? Header { get; set; }
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [JsonPropertyName("body")]
        public required string Body { get; set; }
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
        public required List<ListMessageSection> Sections { get; set; }
    }
}
