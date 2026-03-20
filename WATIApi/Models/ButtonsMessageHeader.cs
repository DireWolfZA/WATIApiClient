using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents the header of a buttons message.
    /// </summary>
    [DataContract(Name = "ButtonsMessageHeaderDto")]
    public class ButtonsMessageHeader {
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
