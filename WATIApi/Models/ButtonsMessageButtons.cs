using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a button in the buttons message.
    /// </summary>
    [DataContract(Name = "ButtonsMessageButtonsDto")]
    public class ButtonsMessageButtons {
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}
