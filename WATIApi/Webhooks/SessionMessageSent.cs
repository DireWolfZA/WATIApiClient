using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/session-message-sent
    public class SessionMessageSent : IWATIEventWithMessageID {
        /// <summary>
        /// The type of webhook event being triggered
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// Unique identifier for this message event
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// WhatsApp's unique identifier for the message
        /// </summary>
        [JsonPropertyName("whatsappMessageId")]
        public string? WhatsAppMessageID { get; set; }
        /// <summary>
        /// Unique identifier for the conversation thread
        /// </summary>
        [JsonPropertyName("conversationId")]
        public string? ConversationID { get; set; }
        /// <summary>
        /// Unique identifier for the support ticket
        /// </summary>
        [JsonPropertyName("ticketId")]
        public string? TicketID { get; set; }
        /// <summary>
        /// The actual text content of the message (null for non-text messages)
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        /// <summary>
        /// Message type, supported values include: "image", "text", "document", "location", "voice", "audio", "button", "interactive", "reaction", "video", "sticker", "contacts", "order", "catalog", "media_placeholder", "template"
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// Additional structured data for complex message types (null for text messages)
        /// </summary>
        [JsonPropertyName("data")]
        public object? Data { get; set; }
        /// <summary>
        /// Unix timestamp when the message was sent
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }
        /// <summary>
        /// Indicates if the message was sent by the business (true) or customer (false)
        /// </summary>
        [JsonPropertyName("owner")]
        public bool? Owner { get; set; }
        /// <summary>
        /// Current delivery status of the message
        /// </summary>
        [JsonPropertyName("statusString")]
        public string? StatusString { get; set; }
        /// <summary>
        /// Unique identifier of the agent assigned to handle this conversation
        /// </summary>
        [JsonPropertyName("assigneeId")]
        public string? AssigneeID { get; set; }
        /// <summary>
        /// Email address of the operator who sent the message
        /// </summary>
        [JsonPropertyName("operatorEmail")]
        public string? OperatorEmail { get; set; }
        /// <summary>
        /// Display name of the operator who sent the message
        /// </summary>
        [JsonPropertyName("operatorName")]
        public string? OperatorName { get; set; }
        /// <summary>
        /// WhatsApp ID of the recipient (phone number with country code)
        /// </summary>
        [JsonPropertyName("waId")]
        public string? WA_ID { get; set; }
    }
}
