using System;
using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    /// <summary>
    /// Model for all possible fields for Message events. Supported webhooks:
    /// <br />`New Contact Message`
    /// <br />`Message Received`
    /// <br />`Template Message Sent v2`
    /// <br />`Session Message Sent v2`
    /// <br />`Sent Message is DELIVERED v2`
    /// <br />`Sent Message is READ v2`
    /// <br />`Sent Message is REPLIED v2`
    /// </summary>
    public class MessageEventAllFields : SentMessageResponseBase {
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
        /// Type of message content, supported values: "image", "text", "document", "location", "voice", "audio", "button", "interactive", "reaction", "video", "sticker", "contacts", "order", "catalog", "media_placeholder", "template"
        /// </summary>
        [JsonPropertyName("type")]
        public override string? Type { get; set; }
        /// <summary>
        /// Unix timestamp. Depends on event type
        /// </summary>
        [JsonPropertyName("timestamp")]
        public override string? Timestamp { get; set; }
        /// <summary>
        /// ID of the agent assigned to handle this conversation. Null if unassigned
        /// </summary>
        [JsonPropertyName("assigneeId")]
        public override string? AssigneeID { get; set; }
        /// <summary>
        /// Email of the operator/system that sent the message
        /// </summary>
        [JsonPropertyName("operatorEmail")]
        public override string? OperatorEmail { get; set; }
        /// <summary>
        /// Identifier for the communication channel. May be null for direct WhatsApp messages
        /// </summary>
        [JsonPropertyName("channelId")]
        public override string? ChannelID { get; set; }
        /// <summary>
        /// The phone number associated with the WhatsApp Business account that sent the message
        /// </summary>
        [JsonPropertyName("channelPhoneNumber")]
        public override string? ChannelPhoneNumber { get; set; }


        /// <summary>
        /// Unique identifier for the template used to send this message
        /// </summary>
        [JsonPropertyName("templateId")]
        public string? TemplateID { get; set; }
        /// <summary>
        /// Name of the template used for sending the message
        /// </summary>
        [JsonPropertyName("templateName")]
        public string? TemplateName { get; set; }
        /// <summary>
        /// Timestamp when the message was created (ISO 8601 format)
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime? Created { get; set; }
        /// <summary>
        /// WhatsApp ID, typically the complete phone number with country code
        /// </summary>
        [JsonPropertyName("waId")]
        public string? WA_ID { get; set; }
        /// <summary>
        /// Depends on event type:
        /// <br /><see cref="TemplateMessageSent"/>: [string] Source from which the message was sent, "WEB" indicates it was sent from the web interface
        /// <br /><see cref="NewContactMessage"/> &amp; <see cref="MessageReceived"/>: [int] Numeric code representing the type of message source (0 = default/unknown)
        /// </summary>
        [JsonPropertyName("sourceType")]
        public object? SourceType { get; set; }
        /// <summary>
        /// Link associated with the template header, null if no header link is present
        /// </summary>
        [JsonPropertyName("headerLink")]
        public string? HeaderLink { get; set; }
        /// <summary>
        /// Type of header in the template (e.g., "text", "image", "video"), null if no header is present
        /// </summary>
        [JsonPropertyName("headerType")]
        public string? HeaderType { get; set; }
        /// <summary>
        /// Additional structured data for complex message types (null for text messages)
        /// </summary>
        [JsonPropertyName("data")]
        public object? Data { get; set; }
        /// <summary>
        /// Indicates if the message was sent by the business (true) or customer (false)
        /// </summary>
        [JsonPropertyName("owner")]
        public bool? Owner { get; set; }
        /// <summary>
        /// Display name of the operator who sent the message
        /// </summary>
        [JsonPropertyName("operatorName")]
        public string? OperatorName { get; set; }
        [JsonPropertyName("chatbotTriggeredEventId")]
        public string? ChatbotTriggeredEventID { get; set; }
        [JsonPropertyName("replyContextId")]
        /// <summary>
        /// Reference ID for the message being replied to (empty if not a reply)
        /// </summary>
        public string? ReplyContextID { get; set; }
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
        /// Contact information shared in the message (for contact message types)
        /// </summary>
        [JsonPropertyName("messageContact")]
        public object? MessageContact { get; set; }
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
        public MessageReceived.ButtonReplyClass? ButtonReply { get; set; }
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
    }
}
