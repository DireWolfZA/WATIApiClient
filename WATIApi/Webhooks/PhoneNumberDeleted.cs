using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/phone-number-deleted
    public class PhoneNumberDeleted : IWATIEventWithWABAID {
        /// <summary>
        /// The type of webhook event. Always set to "phoneNumberDeleted" for this event type.
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// The WhatsApp Business Account ID from which the phone number was deleted. This uniquely identifies the business account.
        /// </summary>
        [JsonPropertyName("wabaId")]
        public string? WABA_ID { get; set; }
        /// <summary>
        /// The phone number that was deleted from the WhatsApp Business Account. Includes country code.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }
    }
}
