using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/sent-message-is-delivered
    /// <summary>Select `Sent Message is DELIVERED v2` event type</summary>
    public class SentMessageDelivered : SentMessageResponseBase {
        /// <summary>
        /// The type of webhook event being triggered
        /// </summary>
        [JsonPropertyName("eventType")]
        public override string? EventType { get; set; }
        /// <summary>
        /// Human-readable status description
        /// </summary>
        [JsonPropertyName("statusString")]
        public override string? StatusString { get; set; }
        /// <summary>
        /// Local system identifier for the message
        /// </summary>
        [JsonPropertyName("localMessageId")]
        public override string? LocalMessageID { get; set; }
        /// <summary>
        /// Unique identifier for this specific event
        /// </summary>
        [JsonPropertyName("id")]
        public override string? ID { get; set; }
        /// <summary>
        /// WhatsApp's internal message identifier
        /// </summary>
        [JsonPropertyName("whatsappMessageId")]
        public override string? WhatsAppMessageID { get; set; }
        /// <summary>
        /// Unique identifier for the conversation thread
        /// </summary>
        [JsonPropertyName("conversationId")]
        public override string? ConversationID { get; set; }
        /// <summary>
        /// Associated support ticket or case identifier
        /// </summary>
        [JsonPropertyName("ticketId")]
        public override string? TicketID { get; set; }
        /// <summary>
        /// Message content (null for template messages)
        /// </summary>
        [JsonPropertyName("text")]
        public override string? Text { get; set; }
        /// <summary>
        /// Type of message content, support value: "image", "text", "document", "location", "voice", "audio", "button", "interactive", "reaction", "video", "sticker", "contacts", "order", "catalog", "media_placeholder"
        /// </summary>
        [JsonPropertyName("type")]
        public override string? Type { get; set; }
        /// <summary>
        /// Unix timestamp when the message was delivered
        /// </summary>
        [JsonPropertyName("timestamp")]
        public override string? Timestamp { get; set; }
        /// <summary>
        /// ID of the agent assigned to handle this conversation
        /// </summary>
        [JsonPropertyName("assigneeId")]
        public override string? AssigneeID { get; set; }
        /// <summary>
        /// Email of the operator/system that sent the message
        /// </summary>
        [JsonPropertyName("operatorEmail")]
        public override string? OperatorEmail { get; set; }
        /// <summary>
        /// Channel identifier for the messaging platform
        /// </summary>
        [JsonPropertyName("channelId")]
        public override string? ChannelID { get; set; }
        /// <summary>
        /// Phone number associated with the messaging channel
        /// </summary>
        [JsonPropertyName("channelPhoneNumber")]
        public override string? ChannelPhoneNumber { get; set; }
    }
}
