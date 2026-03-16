using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Custom parameter key-value pair.
    /// </summary>
    [DataContract(Name = "CustomParamDto")]
    public partial class CustomParam {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomParam" /> class.
        /// </summary>
        [JsonConstructor]
        protected CustomParam() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomParam" /> class.
        /// </summary>
        /// <param name="name">The name of the custom parameter. (required).</param>
        /// <param name="value">The value of the custom parameter. (required).</param>
        public CustomParam(string name = default, string value = default) {
            // to ensure "name" is required (not null)
            if (name == null)
                throw new ArgumentNullException("name is a required property for CustomParamDto and cannot be null");
            this.Name = name;
            // to ensure "value" is required (not null)
            if (value == null)
                throw new ArgumentNullException("value is a required property for CustomParamDto and cannot be null");
            this.Value = value;
        }

        /// <summary>
        /// The name of the custom parameter.
        /// </summary>
        /// <value>The name of the custom parameter.</value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the custom parameter.
        /// </summary>
        /// <value>The value of the custom parameter.</value>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
