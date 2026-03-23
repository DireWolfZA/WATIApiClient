using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    /// <summary>
    /// Base for webhooks:
    /// <br />`Sent Message is DELIVERED v2`
    /// <br />`Sent Message is READ v2`
    /// <br />`Sent Message is REPLIED v2`
    /// <br />`Template Message Sent v2` (<see cref="Timestamp"/> &amp; <see cref="AssigneeID"/> not included)
    /// <br />`Session Message Sent v2` (<see cref="ChannelID"/> &amp; <see cref="ChannelPhoneNumber"/> not included)
    /// </summary>
    public class SentMessageResponseBase : IWATIEventWithMessageID {
        /// <summary>
        /// The type of webhook event being triggered
        /// </summary>
        [JsonPropertyName("eventType")]
        public virtual string? EventType { get; set; }
        /// <summary>
        /// Human-readable status description
        /// </summary>
        [JsonPropertyName("statusString")]
        public virtual string? StatusString { get; set; }
        /// <summary>
        /// Local system identifier for the message
        /// </summary>
        [JsonPropertyName("localMessageId")]
        public virtual string? LocalMessageID { get; set; }
        /// <summary>
        /// Unique identifier for this specific event
        /// </summary>
        [JsonPropertyName("id")]
        public virtual string? ID { get; set; }
        /// <summary>
        /// WhatsApp's internal message identifier
        /// </summary>
        [JsonPropertyName("whatsappMessageId")]
        public virtual string? WhatsAppMessageID { get; set; }
        /// <summary>
        /// Unique identifier for the conversation thread
        /// </summary>
        [JsonPropertyName("conversationId")]
        public virtual string? ConversationID { get; set; }
        /// <summary>
        /// Associated support ticket or case identifier
        /// </summary>
        [JsonPropertyName("ticketId")]
        public virtual string? TicketID { get; set; }
        /// <summary>
        /// Message content (null for template messages)
        /// </summary>
        [JsonPropertyName("text")]
        public virtual string? Text { get; set; }
        /// <summary>
        /// Type of message content, supported values: "image", "text", "document", "location", "voice", "audio", "button", "interactive", "reaction", "video", "sticker", "contacts", "order", "catalog", "media_placeholder", "template"
        /// </summary>
        [JsonPropertyName("type")]
        public virtual string? Type { get; set; }
        /// <summary>
        /// Unix timestamp. Depends on event type (Not available for <see cref="TemplateMessageSent"/>)
        /// </summary>
        [JsonPropertyName("timestamp")]
        public virtual string? Timestamp { get; set; }
        /// <summary>
        /// ID of the agent assigned to handle this conversation. Null if unassigned (Not available for <see cref="TemplateMessageSent"/>)
        /// </summary>
        [JsonPropertyName("assigneeId")]
        public virtual string? AssigneeID { get; set; }
        /// <summary>
        /// Email of the operator/system that sent the message
        /// </summary>
        [JsonPropertyName("operatorEmail")]
        public virtual string? OperatorEmail { get; set; }
        /// <summary>
        /// Identifier for the communication channel. May be null for direct WhatsApp messages (Not available for <see cref="SessionMessageSent"/>)
        /// </summary>
        [JsonPropertyName("channelId")]
        public virtual string? ChannelID { get; set; }
        /// <summary>
        /// The phone number associated with the WhatsApp Business account that sent the message (Not available for <see cref="SessionMessageSent"/>)
        /// </summary>
        [JsonPropertyName("channelPhoneNumber")]
        public virtual string? ChannelPhoneNumber { get; set; }
    }
}
