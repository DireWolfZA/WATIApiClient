using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a template parameter.
    /// </summary>
    [DataContract(Name = "TemplateParamDto")]
    public partial class TemplateParam {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateParam" /> class.
        /// </summary>
        /// <param name="index">The parameter index..</param>
        /// <param name="paramName">The parameter name..</param>
        public TemplateParam(int index = default, string? paramName = null) {
            this.Index = index;
            this.ParamName = paramName;
        }

        /// <summary>
        /// The parameter index.
        /// </summary>
        /// <value>The parameter index.</value>
        [JsonPropertyName("index")]
        public int Index { get; set; }

        /// <summary>
        /// The parameter name.
        /// </summary>
        /// <value>The parameter name.</value>
        [JsonPropertyName("param_name")]
        public string? ParamName { get; set; }
    }
}
