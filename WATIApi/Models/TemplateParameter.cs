using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a parameter used within a message template.
    /// </summary>
    [DataContract(Name = "TemplateParameterDto")]
    public partial class TemplateParameter {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateParameter" /> class.
        /// </summary>
        /// <param name="name">The name of the template parameter..</param>
        /// <param name="value">The value of the template parameter..</param>
        public TemplateParameter(string? name = null, string? value = null) {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// The name of the template parameter.
        /// </summary>
        /// <value>The name of the template parameter.</value>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The value of the template parameter.
        /// </summary>
        /// <value>The value of the template parameter.</value>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
}
