using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/session-message-sent
    /// <summary>Select `Session Message Sent v2` event type</summary>
    public class SessionMessageSent : SentMessageResponseBase {
        /// <summary>
        /// The type of webhook event being triggered
        /// </summary>
        [JsonPropertyName("eventType")]
        public override string? EventType { get; set; }
        /// <summary>
        /// Unique identifier for this message event
        /// </summary>
        [JsonPropertyName("id")]
        public override string? ID { get; set; }
        /// <summary>
        /// WhatsApp's unique identifier for the message
        /// </summary>
        [JsonPropertyName("whatsappMessageId")]
        public override string? WhatsAppMessageID { get; set; }
        /// <summary>
        /// Unique identifier for the conversation thread
        /// </summary>
        [JsonPropertyName("conversationId")]
        public override string? ConversationID { get; set; }
        /// <summary>
        /// Unique identifier for the support ticket
        /// </summary>
        [JsonPropertyName("ticketId")]
        public override string? TicketID { get; set; }
        /// <summary>
        /// The actual text content of the message (null for non-text messages)
        /// </summary>
        [JsonPropertyName("text")]
        public override string? Text { get; set; }
        /// <summary>
        /// Message type, supported values include: "image", "text", "document", "location", "voice", "audio", "button", "interactive", "reaction", "video", "sticker", "contacts", "order", "catalog", "media_placeholder", "template"
        /// </summary>
        [JsonPropertyName("type")]
        public override string? Type { get; set; }
        /// <summary>
        /// Additional structured data for complex message types (null for text messages)
        /// </summary>
        [JsonPropertyName("data")]
        public object? Data { get; set; }
        /// <summary>
        /// Unix timestamp when the message was sent
        /// </summary>
        [JsonPropertyName("timestamp")]
        public override string? Timestamp { get; set; }
        /// <summary>
        /// Indicates if the message was sent by the business (true) or customer (false)
        /// </summary>
        [JsonPropertyName("owner")]
        public bool? Owner { get; set; }
        /// <summary>
        /// Current delivery status of the message
        /// </summary>
        [JsonPropertyName("statusString")]
        public override string? StatusString { get; set; }
        /// <summary>
        /// Unique identifier of the agent assigned to handle this conversation
        /// </summary>
        [JsonPropertyName("assigneeId")]
        public override string? AssigneeID { get; set; }
        /// <summary>
        /// Email address of the operator who sent the message
        /// </summary>
        [JsonPropertyName("operatorEmail")]
        public override string? OperatorEmail { get; set; }
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

        // not in WATI Webhook Schema...

        /// <summary>
        /// Local system identifier for the message
        /// </summary>
        [JsonPropertyName("localMessageId")]
        public override string? LocalMessageID { get; set; }
        [JsonPropertyName("chatbotTriggeredEventId")]
        public string? ChatbotTriggeredEventID { get; set; }
        /// <summary>
        /// Reference ID for the message being replied to (empty if not a reply)
        /// </summary>
        [JsonPropertyName("replyContextId")]
        public string? ReplyContextID { get; set; }
    }
}
