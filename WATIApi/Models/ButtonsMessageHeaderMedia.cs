using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents media information inside the header.
    /// </summary>
    [DataContract(Name = "ButtonsMessageHeaderMediaDto")]
    public partial class ButtonsMessageHeaderMedia {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonsMessageHeaderMedia" /> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="data">data.</param>
        /// <param name="mimeType">mimeType.</param>
        /// <param name="filePath">filePath.</param>
        public ButtonsMessageHeaderMedia(string? url = null, string? fileName = null) {
            this.URL = url;
            this.FileName = fileName;
        }

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
