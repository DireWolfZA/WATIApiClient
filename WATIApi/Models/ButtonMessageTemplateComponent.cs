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
        /// Initializes a new instance of the <see cref="ButtonMessageTemplateComponent" /> class.
        /// </summary>
        /// <param name="type">The type of button component.</param>
        /// <param name="varParameter">varParameter.</param>
        public ButtonMessageTemplateComponent(string? type = null, ButtonMessageTemplateComponentParameter? parameter = null) {
            this.Type = type;
            this.Parameter = parameter ?? throw new ArgumentNullException(nameof(parameter));
        }

        /// <summary>
        /// The type of button component.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// Gets or Sets Parameter
        /// </summary>
        [JsonPropertyName("parameter")]
        public ButtonMessageTemplateComponentParameter Parameter { get; set; }
    }
}
