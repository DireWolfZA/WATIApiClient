using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/phone-number-quality-update
    public class PhoneNumberQualityUpdate {
        /// <summary>
        /// Always set to "PhoneNumberQualityUpdatedEvent" for this webhook type
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// The phone number that experienced the quality update, including country code
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// The type of quality change that occurred. See event types below for possible values
        /// </summary>
        [JsonPropertyName("event")]
        public string? Event { get; set; }
        /// <summary>
        /// Indicates current messaging limit or throughput level.
        /// <br />Values can be:
        /// <br />TIER_50 - Indicates a messaging limit of 50.
        /// <br />TIER_250 - Indicates a messaging limit of 250.
        /// <br />TIER_1K - Indicates a messaging limit of 1,000.
        /// <br />TIER_10K - Indicates a messaging limit of 10,000.
        /// <br />TIER_100K - Indicates a messaging limit of 100,000.
        /// <br />TIER_NOT_SET - Indicates the business phone number has not been used to send a message yet.
        /// <br />TIER_UNLIMITED - Indicates the business phone number has higher throughput.
        /// </summary>
        [JsonPropertyName("currentLimit")]
        public string? CurrentLimit { get; set; }
        /// <summary>
        /// Indicates messaging limit or throughput level.
        /// <br />Values can be:
        /// <br />TIER_50 - Indicates a messaging limit of 50.
        /// <br />TIER_250 - Indicates a messaging limit of 250.
        /// <br />TIER_1K - Indicates a messaging limit of 1,000.
        /// <br />TIER_10K - Indicates a messaging limit of 10,000.
        /// <br />TIER_100K - Indicates a messaging limit of 100,000.
        /// <br />TIER_NOT_SET - Indicates the business phone number has not been used to send a message yet.
        /// <br />TIER_UNLIMITED - Indicates the business phone number has higher throughput.
        /// </summary>
        [JsonPropertyName("oldLimit")]
        public string? OldLimit { get; set; }
        /// <summary>
        /// The unique identifier of the channel associated with the phone number (null for default channel)
        /// </summary>
        [JsonPropertyName("channelId")]
        public string? ChannelID { get; set; }
        /// <summary>
        /// The phone number of the channel from which the update originated
        /// </summary>
        [JsonPropertyName("channelPhoneNumber")]
        public string? ChannelPhoneNumber { get; set; }
    }
}
