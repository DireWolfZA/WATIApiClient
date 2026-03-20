using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a carousel message template view model.
    /// </summary>
    [DataContract(Name = "CarouselMessageTemplateViewModelDto")]
    public class CarouselMessageTemplateViewModel {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarouselMessageTemplateViewModel" /> class.
        /// </summary>
        /// <param name="header">header.</param>
        /// <param name="body">The body content.</param>
        /// <param name="bodyOriginal">The original body content.</param>
        /// <param name="bodyParamMapping">The body parameter mapping.</param>
        /// <param name="buttons">The list of buttons.</param>
        /// <param name="buttonsType">The type of buttons.</param>
        public CarouselMessageTemplateViewModel(HeaderMessageTemplateComponent? header = null, string? body = null, string? bodyOriginal = null, List<TemplateParam>? bodyParamMapping = null, List<ButtonMessageTemplateComponent>? buttons = null, string? buttonsType = null) {
            this.Header = header ?? throw new ArgumentNullException(nameof(header));
            this.Body = body;
            this.BodyOriginal = bodyOriginal;
            this.BodyParamMapping = bodyParamMapping;
            this.Buttons = buttons;
            this.ButtonsType = buttonsType;
        }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [JsonPropertyName("header")]
        public HeaderMessageTemplateComponent Header { get; set; }
        /// <summary>
        /// The body content.
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get; set; }
        /// <summary>
        /// The original body content.
        /// </summary>
        [JsonPropertyName("body_original")]
        public string? BodyOriginal { get; set; }
        /// <summary>
        /// The body parameter mapping.
        /// </summary>
        [JsonPropertyName("body_param_mapping")]
        public List<TemplateParam>? BodyParamMapping { get; set; }
        /// <summary>
        /// The list of buttons.
        /// </summary>
        [JsonPropertyName("buttons")]
        public List<ButtonMessageTemplateComponent>? Buttons { get; set; }
        /// <summary>
        /// The type of buttons.
        /// </summary>
        [JsonPropertyName("buttons_type")]
        public string? ButtonsType { get; set; }
    }
}
