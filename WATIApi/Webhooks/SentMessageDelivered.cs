using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/sent-message-is-delivered
    /// <summary>Select `Sent Message is DELIVERED v2` event type</summary>
    public class SentMessageDelivered : IWATIEventWithMessageID {
        /// <summary>
        /// The type of webhook event being triggered
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// Human-readable status description
        /// </summary>
        [JsonPropertyName("statusString")]
        public string? StatusString { get; set; }
        /// <summary>
        /// Local system identifier for the message
        /// </summary>
        [JsonPropertyName("localMessageId")]
        public string? LocalMessageID { get; set; }
        /// <summary>
        /// Unique identifier for this specific event
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// WhatsApp's internal message identifier
        /// </summary>
        [JsonPropertyName("whatsappMessageId")]
        public string? WhatsAppMessageID { get; set; }
        /// <summary>
        /// Unique identifier for the conversation thread
        /// </summary>
        [JsonPropertyName("conversationId")]
        public string? ConversationID { get; set; }
        /// <summary>
        /// Associated support ticket or case identifier
        /// </summary>
        [JsonPropertyName("ticketId")]
        public string? TicketID { get; set; }
        /// <summary>
        /// Message content (null for template messages)
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        /// <summary>
        /// Type of message content, support value: "image", "text", "document", "location", "voice", "audio", "button", "interactive", "reaction", "video", "sticker", "contacts", "order", "catalog", "media_placeholder"
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// Unix timestamp when the message was delivered
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }
        /// <summary>
        /// ID of the agent assigned to handle this conversation
        /// </summary>
        [JsonPropertyName("assigneeId")]
        public string? AssigneeID { get; set; }
        /// <summary>
        /// Email of the operator/system that sent the message
        /// </summary>
        [JsonPropertyName("operatorEmail")]
        public string? OperatorEmail { get; set; }
        /// <summary>
        /// Channel identifier for the messaging platform
        /// </summary>
        [JsonPropertyName("channelId")]
        public string? ChannelID { get; set; }
        /// <summary>
        /// Phone number associated with the messaging channel
        /// </summary>
        [JsonPropertyName("channelPhoneNumber")]
        public string? ChannelPhoneNumber { get; set; }
    }
}
