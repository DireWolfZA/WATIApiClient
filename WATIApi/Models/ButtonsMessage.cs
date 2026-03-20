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
        /// Initializes a new instance of the <see cref="ButtonsMessage" /> class.
        /// </summary>
        /// <param name="header">Represents the header of a buttons message.</param>
        /// <param name="body">The body text of the message.</param>
        /// <param name="footer">The footer text of the message.</param>
        /// <param name="buttons">The list of buttons.</param>
        public ButtonsMessage(ButtonsMessageHeader header, string? body = null, string? footer = null, List<ButtonsMessageButtons>? buttons = null) {
            this.Header = header;
            this.Body = body;
            this.Footer = footer;
            this.Buttons = buttons;
        }

        /// <summary>
        /// Represents the header of a buttons message.
        /// </summary>
        [JsonPropertyName("header")]
        public ButtonsMessageHeader Header { get; set; }
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
