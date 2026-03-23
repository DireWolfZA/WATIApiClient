using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/message-received
    public class MessageReceived {
        /// <summary>
        /// Unique identifier for the message record
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// ISO 8601 timestamp when the message was created in the system
        /// </summary>
        [JsonPropertyName("created")]
        public string? Created { get; set; }
        /// <summary>
        /// WhatsApp's unique message identifier (WAMID)
        /// </summary>
        [JsonPropertyName("whatsappMessageId")]
        public string? WhatsAppMessageID { get; set; }
        /// <summary>
        /// Unique identifier for the conversation thread
        /// </summary>
        [JsonPropertyName("conversationId")]
        public string? ConversationID { get; set; }
        /// <summary>
        /// Unique identifier for the support ticket associated with this message
        /// </summary>
        [JsonPropertyName("ticketId")]
        public string? TicketID { get; set; }
        /// <summary>
        /// The actual text content of the message
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        /// <summary>
        /// Type of message content, support value: "image", "text", "document", "location", "voice", "audio", "button", "interactive", "reaction", "video", "sticker", "contacts", "order", "catalog", "media_placeholder"
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// Additional data payload for non-text message types
        /// </summary>
        [JsonPropertyName("data")]
        public object? Data { get; set; }
        /// <summary>
        /// Identifier for the message source (if applicable)
        /// </summary>
        [JsonPropertyName("sourceId")]
        public string? SourceID { get; set; }
        /// <summary>
        /// URL reference for the message source (if applicable)
        /// </summary>
        [JsonPropertyName("sourceUrl")]
        public string? SourceURL { get; set; }
        /// <summary>
        /// Unix timestamp when the message was sent
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }
        /// <summary>
        /// Indicates if the message was sent by the account owner
        /// </summary>
        [JsonPropertyName("owner")]
        public bool? Owner { get; set; }
        /// <summary>
        /// Type of event this record represents
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// Current status of the message
        /// </summary>
        [JsonPropertyName("statusString")]
        public string? StatusString { get; set; }
        /// <summary>
        /// URL to the sender's profile picture
        /// </summary>
        [JsonPropertyName("avatarUrl")]
        public string? AvatarURL { get; set; }
        /// <summary>
        /// Unique identifier of the operator assigned to handle this conversation
        /// </summary>
        [JsonPropertyName("assignedId")]
        public string? AssignedID { get; set; }
        /// <summary>
        /// Full name of the assigned operator
        /// </summary>
        [JsonPropertyName("operatorName")]
        public string? OperatorName { get; set; }
        /// <summary>
        /// Email address of the assigned operator
        /// </summary>
        [JsonPropertyName("operatorEmail")]
        public string? OperatorEmail { get; set; }
        /// <summary>
        /// WhatsApp ID of the message sender
        /// </summary>
        [JsonPropertyName("waId")]
        public string? WA_ID { get; set; }
        /// <summary>
        /// Contact information shared in the message (for contact message types)
        /// </summary>
        [JsonPropertyName("messageContact")]
        public object? MessageContact { get; set; }
        /// <summary>
        /// Display name of the message sender
        /// </summary>
        [JsonPropertyName("senderName")]
        public string? SenderName { get; set; }
        /// <summary>
        /// Data for list selection replies (WhatsApp interactive messages)
        /// </summary>
        [JsonPropertyName("listReply")]
        public object? ListReply { get; set; }
        /// <summary>
        /// Data for interactive button replies
        /// </summary>
        [JsonPropertyName("interactiveButtonReply")]
        public object? InteractiveButtonReply { get; set; }
        /// <summary>
        /// Data for quick reply button responses
        /// </summary>
        [JsonPropertyName("buttonReply")]
        public object? ButtonReply { get; set; }
        /// <summary>
        /// Reference ID for the message being replied to (empty if not a reply)
        /// </summary>
        [JsonPropertyName("replyContextId")]
        public string? ReplyContextID { get; set; }
        /// <summary>
        /// Numeric code indicating the message source type
        /// </summary>
        [JsonPropertyName("sourceType")]
        public int? SourceType { get; set; }
        /// <summary>
        /// WhatsApp flag indicating if message has been forwarded multiple times
        /// </summary>
        [JsonPropertyName("frequentlyForwarded")]
        public bool? FrequentlyForwarded { get; set; }
        /// <summary>
        /// Indicates if this message was forwarded
        /// </summary>
        [JsonPropertyName("forwarded")]
        public bool? Forwarded { get; set; }
        /// <summary>
        /// Identifier for the communication channel (if using multi-channel setup)
        /// </summary>
        [JsonPropertyName("channelId")]
        public string? ChannelID { get; set; }
        /// <summary>
        /// Phone number of the WhatsApp Business account receiving the message
        /// </summary>
        [JsonPropertyName("channelPhoneNumber")]
        public string? ChannelPhoneNumber { get; set; }
    }
}
