using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a limited time offer configuration for a message template.
    /// </summary>
    [DataContract(Name = "LimitedTimeOfferDto")]
    public partial class LimitedTimeOffer {
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitedTimeOffer" /> class.
        /// </summary>
        /// <param name="text">The offer text description..</param>
        /// <param name="hasExpiration">Whether the offer has an expiration time..</param>
        /// <param name="expirationTime">The expiration date and time of the offer..</param>
        public LimitedTimeOffer(string? text = null, bool hasExpiration = default, DateTime expirationTime = default) {
            this.Text = text;
            this.HasExpiration = hasExpiration;
            this.ExpirationTime = expirationTime;
        }

        /// <summary>
        /// The offer text description.
        /// </summary>
        /// <value>The offer text description.</value>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Whether the offer has an expiration time.
        /// </summary>
        /// <value>Whether the offer has an expiration time.</value>
        [JsonPropertyName("has_expiration")]
        public bool HasExpiration { get; set; }

        /// <summary>
        /// The expiration date and time of the offer.
        /// </summary>
        /// <value>The expiration date and time of the offer.</value>
        [JsonPropertyName("expiration_time")]
        public DateTime ExpirationTime { get; set; }
    }
}
