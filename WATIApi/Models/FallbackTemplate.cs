using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// FallbackTemplate
    /// </summary>
    [DataContract(Name = "FallbackTemplate")]
    public partial class FallbackTemplate {
        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackTemplate" /> class.
        /// </summary>
        /// <param name="templateId">templateId.</param>
        /// <param name="type">type.</param>
        /// <param name="providerType">providerType.</param>
        public FallbackTemplate(string? templateId = null, int type = default, int providerType = default) {
            this.TemplateID = templateId;
            this.Type = type;
            this.ProviderType = providerType;
        }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [JsonPropertyName("templateId")]
        public string? TemplateID { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// Gets or Sets ProviderType
        /// </summary>
        [JsonPropertyName("providerType")]
        public int ProviderType { get; set; }
    }
}
