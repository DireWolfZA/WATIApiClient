using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents media information inside the header.
    /// </summary>
    [DataContract(Name = "ButtonsMessageHeaderMediaDto")]
    public class ButtonsMessageHeaderMedia {
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [JsonPropertyName("url")]
        public string? URL { get; set; }
        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [JsonPropertyName("file_name")]
        public string? FileName { get; set; }
    }
}
