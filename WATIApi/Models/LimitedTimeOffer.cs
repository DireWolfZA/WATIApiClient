using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a limited time offer configuration for a message template.
    /// </summary>
    [DataContract(Name = "LimitedTimeOfferDto")]
    public class LimitedTimeOffer {
        /// <summary>
        /// The offer text description.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        /// <summary>
        /// Whether the offer has an expiration time.
        /// </summary>
        [JsonPropertyName("has_expiration")]
        public bool HasExpiration { get; set; }
        /// <summary>
        /// The expiration date and time of the offer.
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public DateTime ExpirationTime { get; set; }
    }
}
