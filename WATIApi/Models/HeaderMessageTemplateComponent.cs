using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a header component for a message template.
    /// </summary>
    [DataContract(Name = "HeaderMessageTemplateComponentDto")]
    public partial class HeaderMessageTemplateComponent {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderMessageTemplateComponent" /> class.
        /// </summary>
        /// <param name="type">The type of header component..</param>
        /// <param name="text">The text content of the header..</param>
        /// <param name="link">The link associated with the header..</param>
        /// <param name="mediaHeaderID">The media header identifier..</param>
        /// <param name="mediaFromPC">The media from PC identifier..</param>
        /// <param name="headerOriginal">The original header content..</param>
        /// <param name="headerParamMapping">headerParamMapping.</param>
        public HeaderMessageTemplateComponent(string? type = null, string? text = null, string? link = null, string? mediaHeaderID = null, string? mediaFromPC = null, string? headerOriginal = null, TemplateParam? headerParamMapping = null) {
            this.Type = type;
            this.Text = text;
            this.Link = link;
            this.MediaHeaderID = mediaHeaderID;
            this.MediaFromPC = mediaFromPC;
            this.HeaderOriginal = headerOriginal;
            this.HeaderParamMapping = headerParamMapping;
        }

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
        /// Gets or Sets HeaderParamMapping
        /// </summary>
        [JsonPropertyName("header_param_mapping")]
        public TemplateParam? HeaderParamMapping { get; set; }
    }
}
