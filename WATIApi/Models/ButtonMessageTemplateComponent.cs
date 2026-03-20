using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a button component for a message template.
    /// </summary>
    [DataContract(Name = "ButtonMessageTemplateComponentDto")]
    public class ButtonMessageTemplateComponent {
        /// <summary>
        /// The type of button component.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// Gets or Sets Parameter
        /// </summary>
        [JsonPropertyName("parameter")]
        public required ButtonMessageTemplateComponentParameter Parameter { get; set; }
    }
}
