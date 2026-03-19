using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents parameters for a button component.
    /// </summary>
    [DataContract(Name = "ButtonMessageTemplateComponentParameterDto")]
    public partial class ButtonMessageTemplateComponentParameter {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonMessageTemplateComponentParameter" /> class.
        /// </summary>
        /// <param name="text">The button text..</param>
        /// <param name="phoneNumber">The phone number for call buttons..</param>
        /// <param name="url">The URL for URL buttons..</param>
        /// <param name="urlOriginal">The original URL content..</param>
        /// <param name="urlType">The type of URL..</param>
        /// <param name="buttonParamMapping">buttonParamMapping.</param>
        /// <param name="copyOfferCode">The copy offer code..</param>
        /// <param name="orderDetails">orderDetails.</param>
        public ButtonMessageTemplateComponentParameter(string? text = null, string? phoneNumber = null, string? url = null, string? urlOriginal = null, string? urlType = default, TemplateParam? buttonParamMapping = null, string? copyOfferCode = null, OrderDetailsParameters? orderDetails = null) {
            this.Text = text;
            this.PhoneNumber = phoneNumber;
            this.URL = url;
            this.URLOriginal = urlOriginal;
            this.URLType = urlType;
            this.ButtonParamMapping = buttonParamMapping;
            this.CopyOfferCode = copyOfferCode;
            this.OrderDetails = orderDetails;
        }

        /// <summary>
        /// The button text.
        /// </summary>
        /// <value>The button text.</value>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The phone number for call buttons.
        /// </summary>
        /// <value>The phone number for call buttons.</value>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// The URL for URL buttons.
        /// </summary>
        /// <value>The URL for URL buttons.</value>
        [JsonPropertyName("url")]
        public string? URL { get; set; }

        /// <summary>
        /// The original URL content.
        /// </summary>
        /// <value>The original URL content.</value>
        [JsonPropertyName("url_original")]
        public string? URLOriginal { get; set; }

        /// <summary>
        /// The type of URL.
        /// </summary>
        /// <value>The type of URL.</value>
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
        /// <value>The copy offer code.</value>
        [JsonPropertyName("copy_offer_code")]
        public string? CopyOfferCode { get; set; }

        /// <summary>
        /// Gets or Sets OrderDetails
        /// </summary>
        [JsonPropertyName("order_details")]
        public OrderDetailsParameters? OrderDetails { get; set; }
    }
}
