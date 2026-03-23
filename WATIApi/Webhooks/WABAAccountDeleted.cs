using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/waba-account-deleted
    public class WABAAccountDeleted : IWATIEventWithWABAID {
        /// <summary>
        /// The type of webhook event. For WABA status updates, this value is always "accountDeleted"
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// The unique identifier of the WhatsApp Business Account that underwent the review process
        /// </summary>
        [JsonPropertyName("wabaId")]
        public string? WABA_ID { get; set; }
    }
}
