using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/send-message-is-read
    public class SentMessageRead {
        /// <summary>
        /// The type of webhook event. Always "sentMessageREAD_v2" for this webhook version
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// Human-readable status of the message. Shows "Read" when the message has been read
        /// </summary>
        [JsonPropertyName("statusString")]
        public string? StatusString { get; set; }
        /// <summary>
        /// Local unique identifier for the message used for internal tracking
        /// </summary>
        [JsonPropertyName("localMessageId")]
        public string? LocalMessageID { get; set; }
        /// <summary>
        /// Unique internal identifier for this message
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// WhatsApp's unique message identifier (WAMID) for tracking messages in WhatsApp's system
        /// </summary>
        [JsonPropertyName("whatsappMessageId")]
        public string? WhatsAppMessageID { get; set; }
        /// <summary>
        /// Unique identifier for the conversation thread this message belongs to
        /// </summary>
        [JsonPropertyName("conversationId")]
        public string? ConversationID { get; set; }
        /// <summary>
        /// Unique identifier for the support ticket associated with this conversation
        /// </summary>
        [JsonPropertyName("ticketId")]
        public string? TicketID { get; set; }
        /// <summary>
        /// The actual text content of the message that was sent
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        /// <summary>
        /// Message type, supported values include: "image", "text", "document", "location", "voice", "audio", "button", "interactive", "reaction", "video", "sticker", "contacts", "order", "catalog", "media_placeholder", "template"
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// Unix timestamp indicating when the message was originally sent
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }
        /// <summary>
        /// Unique identifier of the agent or user assigned to handle this conversation
        /// </summary>
        [JsonPropertyName("assigneeId")]
        public string? AssigneeID { get; set; }
        /// <summary>
        /// Email address of the operator/agent who sent the message
        /// </summary>
        [JsonPropertyName("operatorEmail")]
        public string? OperatorEmail { get; set; }
        /// <summary>
        /// Identifier for the communication channel. May be null for direct WhatsApp messages
        /// </summary>
        [JsonPropertyName("channelId")]
        public string? ChannelID { get; set; }
        /// <summary>
        /// The phone number associated with the WhatsApp Business account that sent the message
        /// </summary>
        [JsonPropertyName("channelPhoneNumber")]
        public string? ChannelPhoneNumber { get; set; }
    }
}
