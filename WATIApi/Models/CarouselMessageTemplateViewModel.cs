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
        /// Gets or Sets Header
        /// </summary>
        [JsonPropertyName("header")]
        public required HeaderMessageTemplateComponent Header { get; set; }
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
