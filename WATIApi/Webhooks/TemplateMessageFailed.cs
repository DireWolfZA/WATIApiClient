using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/template-message-failed
    public class TemplateMessageFailed {
        /// <summary>
        /// The type of webhook event that was triggered
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// Human-readable status description of the message
        /// </summary>
        [JsonPropertyName("statusString")]
        public string? StatusString { get; set; }
        /// <summary>
        /// Local unique identifier for the message within WATI's system
        /// </summary>
        [JsonPropertyName("localMessageId")]
        public string? LocalMessageID { get; set; }
        /// <summary>
        /// Error code indicating the specific reason for message failure
        /// </summary>
        [JsonPropertyName("failedCode")]
        public string? FailedCode { get; set; }
        /// <summary>
        /// Detailed description of why the message failed to deliver
        /// </summary>
        [JsonPropertyName("failedDetail")]
        public string? FailedDetail { get; set; }
        /// <summary>
        /// Unique identifier for this message within the WATI system
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
        /// Support ticket ID associated with this conversation
        /// </summary>
        [JsonPropertyName("ticketId")]
        public string? TicketID { get; set; }
        /// <summary>
        /// The actual message content. <see langword="null"/> for template messages
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        /// <summary>
        /// Message type classification
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// Unix timestamp indicating when the message was processed
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }
        /// <summary>
        /// ID of the agent assigned to handle this conversation. <see langword="null"/> if unassigned
        /// </summary>
        [JsonPropertyName("assigneeId")]
        public string? AssigneeID { get; set; }
        /// <summary>
        /// Email address of the operator/agent who sent the message
        /// </summary>
        [JsonPropertyName("operatorEmail")]
        public string? OperatorEmail { get; set; }
    }
}
