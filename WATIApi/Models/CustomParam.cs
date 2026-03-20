using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Custom parameter key-value pair.
    /// </summary>
    [DataContract(Name = "CustomParamDto")]
    public class CustomParam {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomParam" /> class.
        /// </summary>
        /// <param name="name">The name of the custom parameter. (required).</param>
        /// <param name="value">The value of the custom parameter. (required).</param>
        public CustomParam(string name, string value) {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// The name of the custom parameter.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        /// <summary>
        /// The value of the custom parameter.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
