using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents order details parameters.
    /// </summary>
    [DataContract(Name = "OrderDetailsParametersDto")]
    public class OrderDetailsParameters {
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
