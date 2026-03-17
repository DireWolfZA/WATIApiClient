using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a button in the buttons message.
    /// </summary>
    [DataContract(Name = "ButtonsMessageButtonsDto")]
    public partial class ButtonsMessageButtons {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonsMessageButtons" /> class.
        /// </summary>
        /// <param name="text">text.</param>
        public ButtonsMessageButtons(string? text = null) {
            this.Text = text;
        }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}
