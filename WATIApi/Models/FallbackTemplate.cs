using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// FallbackTemplate
    /// </summary>
    [DataContract(Name = "FallbackTemplate")]
    public class FallbackTemplate {
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
