using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/waba-status-review-update
    public class WABAStatusUpdate {
        /// <summary>
        /// The type of webhook event. For WABA status updates, this value is always "wabaStatusReviewUpdate"
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// Indicates the WhatsApp Business Account review outcome. Possible values:
        /// <br />APPROVED - WABA is approved and ready for use
        /// <br />REJECTED - WABA was rejected due to policy violations and cannot be used with APIs
        /// <br />PENDING - Review decision is still pending, WABA cannot be used with APIs
        /// <br />DEFERRED - Review decision has been deferred, WABA currently cannot be used with APIs
        /// </summary>
        [JsonPropertyName("accountReviewStatus")]
        public string? AccountReviewStatus { get; set; }
        /// <summary>
        /// The unique identifier of the WhatsApp Business Account that underwent the review process
        /// </summary>
        [JsonPropertyName("wabaId")]
        public string? WABA_ID { get; set; }
    }
}
