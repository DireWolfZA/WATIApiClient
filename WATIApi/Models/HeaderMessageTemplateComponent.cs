using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a header component for a message template.
    /// </summary>
    [DataContract(Name = "HeaderMessageTemplateComponentDto")]
    public class HeaderMessageTemplateComponent {
        /// <summary>
        /// The type of header component.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// The text content of the header.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        /// <summary>
        /// The link associated with the header.
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }
        /// <summary>
        /// The media header identifier.
        /// </summary>
        [JsonPropertyName("media_header_id")]
        public string? MediaHeaderID { get; set; }
        /// <summary>
        /// The media from PC identifier.
        /// </summary>
        [JsonPropertyName("media_from_pc")]
        public string? MediaFromPC { get; set; }
        /// <summary>
        /// The original header content.
        /// </summary>
        [JsonPropertyName("header_original")]
        public string? HeaderOriginal { get; set; }
        /// <summary>
        /// Represents a template parameter.
        /// </summary>
        [JsonPropertyName("header_param_mapping")]
        public TemplateParam? HeaderParamMapping { get; set; }
    }
}
