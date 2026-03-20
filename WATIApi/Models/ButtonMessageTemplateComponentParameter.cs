using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents parameters for a button component.
    /// </summary>
    [DataContract(Name = "ButtonMessageTemplateComponentParameterDto")]
    public class ButtonMessageTemplateComponentParameter {
        /// <summary>
        /// The button text.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        /// <summary>
        /// The phone number for call buttons.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// The URL for URL buttons.
        /// </summary>
        [JsonPropertyName("url")]
        public string? URL { get; set; }
        /// <summary>
        /// The original URL content.
        /// </summary>
        [JsonPropertyName("url_original")]
        public string? URLOriginal { get; set; }
        /// <summary>
        /// The type of URL.
        /// </summary>
        [JsonPropertyName("url_type")]
        public string? URLType { get; set; }
        /// <summary>
        /// Gets or Sets ButtonParamMapping
        /// </summary>
        [JsonPropertyName("button_param_mapping")]
        public TemplateParam? ButtonParamMapping { get; set; }
        /// <summary>
        /// The copy offer code.
        /// </summary>
        [JsonPropertyName("copy_offer_code")]
        public string? CopyOfferCode { get; set; }
        /// <summary>
        /// Gets or Sets OrderDetails
        /// </summary>
        [JsonPropertyName("order_details")]
        public OrderDetailsParameters? OrderDetails { get; set; }
    }
}
