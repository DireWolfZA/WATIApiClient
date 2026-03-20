using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a message with buttons in a conversation.
    /// </summary>
    [DataContract(Name = "ButtonsMessageDto")]
    public class ButtonsMessage {
        /// <summary>
        /// Represents the header of a buttons message.
        /// </summary>
        [JsonPropertyName("header")]
        public required ButtonsMessageHeader Header { get; set; }
        /// <summary>
        /// The body text of the message.
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get; set; }
        /// <summary>
        /// The footer text of the message.
        /// </summary>
        [JsonPropertyName("footer")]
        public string? Footer { get; set; }
        /// <summary>
        /// The list of buttons.
        /// </summary>
        [JsonPropertyName("buttons")]
        public List<ButtonsMessageButtons>? Buttons { get; set; }
    }
}
