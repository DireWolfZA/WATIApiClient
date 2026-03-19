using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents order details parameters.
    /// </summary>
    [DataContract(Name = "OrderDetailsParametersDto")]
    public partial class OrderDetailsParameters {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailsParameters" /> class.
        /// </summary>
        /// <param name="referenceID">The reference identifier..</param>
        /// <param name="type">The parameter type..</param>
        /// <param name="paymentConfiguration">The payment configuration..</param>
        /// <param name="currency">The currency..</param>
        /// <param name="totalAmount">The total amount..</param>
        /// <param name="order">The order details..</param>
        /// <param name="paymentType">The payment type..</param>
        /// <param name="beneficiaries">The list of beneficiaries..</param>
        /// <param name="paymentSettings">The payment settings..</param>
        /// <param name="shippingInfo">The shipping information..</param>
        public OrderDetailsParameters(string? referenceID = null, string? type = null, string? paymentConfiguration = null, string? currency = null, string? totalAmount = null, string? order = null, string? paymentType = null, string? beneficiaries = null, string? paymentSettings = null, string? shippingInfo = null) {
            this.ReferenceID = referenceID;
            this.Type = type;
            this.PaymentConfiguration = paymentConfiguration;
            this.Currency = currency;
            this.TotalAmount = totalAmount;
            this.Order = order;
            this.PaymentType = paymentType;
            this.Beneficiaries = beneficiaries;
            this.PaymentSettings = paymentSettings;
            this.ShippingInfo = shippingInfo;
        }

        /// <summary>
        /// The reference identifier.
        /// </summary>
        [JsonPropertyName("reference_id")]
        public string? ReferenceID { get; set; }
        /// <summary>
        /// The parameter type.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// The payment configuration.
        /// </summary>
        [JsonPropertyName("payment_configuration")]
        public string? PaymentConfiguration { get; set; }
        /// <summary>
        /// The currency.
        /// </summary>
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
        /// <summary>
        /// The total amount.
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string? TotalAmount { get; set; }
        /// <summary>
        /// The order details.
        /// </summary>
        [JsonPropertyName("order")]
        public string? Order { get; set; }
        /// <summary>
        /// The payment type.
        /// </summary>
        [JsonPropertyName("payment_type")]
        public string? PaymentType { get; set; }
        /// <summary>
        /// The list of beneficiaries.
        /// </summary>
        [JsonPropertyName("beneficiaries")]
        public string? Beneficiaries { get; set; }
        /// <summary>
        /// The payment settings.
        /// </summary>
        [JsonPropertyName("payment_settings")]
        public string? PaymentSettings { get; set; }
        /// <summary>
        /// The shipping information.
        /// </summary>
        [JsonPropertyName("shipping_info")]
        public string? ShippingInfo { get; set; }
    }
}
