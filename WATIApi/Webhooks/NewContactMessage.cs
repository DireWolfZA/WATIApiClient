using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/new-contact-message
    public class NewContactMessage {
        /// <summary>
        /// Identifies the type of webhook event being triggered
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// Unique identifier for this specific message event
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// Timestamp when the message was received, in UTC format
        /// </summary>
        [JsonPropertyName("created")]
        public string? Created { get; set; }
        /// <summary>
        /// WhatsApp ID or phone number of the message sender
        /// </summary>
        [JsonPropertyName("waId")]
        public string? WA_ID { get; set; }
        /// <summary>
        /// Display name of the person who sent the message
        /// </summary>
        [JsonPropertyName("senderName")]
        public string? SenderName { get; set; }
        /// <summary>
        /// Internal identifier for the message source (null if not applicable)
        /// </summary>
        [JsonPropertyName("sourceId")]
        public string? SourceID { get; set; }
        /// <summary>
        /// URL reference to the source of the message (null if not applicable)
        /// </summary>
        [JsonPropertyName("sourceUrl")]
        public string? SourceURL { get; set; }
        /// <summary>
        /// Numeric code representing the type of message source (0 = default/unknown)
        /// </summary>
        [JsonPropertyName("sourceType")]
        public int? SourceType { get; set; }
    }
}
