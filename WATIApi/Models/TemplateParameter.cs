using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a parameter used within a message template.
    /// </summary>
    [DataContract(Name = "TemplateParameterDto")]
    public class TemplateParameter {
        /// <summary>
        /// The name of the template parameter.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// The value of the template parameter.
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
}
