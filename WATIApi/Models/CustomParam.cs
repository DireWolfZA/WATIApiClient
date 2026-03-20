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
        /// The name of the custom parameter.
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; set; }
        /// <summary>
        /// The value of the custom parameter.
        /// </summary>
        [JsonPropertyName("value")]
        public required string Value { get; set; }
    }
}
