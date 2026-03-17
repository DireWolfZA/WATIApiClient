using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents the header of a buttons message.
    /// </summary>
    [DataContract(Name = "ButtonsMessageHeaderDto")]
    public partial class ButtonsMessageHeader {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonsMessageHeader" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="text">text.</param>
        /// <param name="media">Represents media information inside the header.</param>
        public ButtonsMessageHeader(string? type = null, string? text = null, ButtonsMessageHeaderMedia? media = null) {
            this.Type = type;
            this.Text = text;
            this.Media = media;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Represents media information inside the header.
        /// </summary>
        [JsonPropertyName("media")]
        public ButtonsMessageHeaderMedia? Media { get; set; }
    }
}
