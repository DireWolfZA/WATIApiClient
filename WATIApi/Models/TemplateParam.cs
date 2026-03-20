using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a template parameter.
    /// </summary>
    [DataContract(Name = "TemplateParamDto")]
    public class TemplateParam {
        /// <summary>
        /// The parameter index.
        /// </summary>
        [JsonPropertyName("index")]
        public int Index { get; set; }
        /// <summary>
        /// The parameter name.
        /// </summary>
        [JsonPropertyName("param_name")]
        public string? ParamName { get; set; }
    }
}
