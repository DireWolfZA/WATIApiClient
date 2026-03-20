using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a message event within a conversation.
    /// </summary>
    [DataContract(Name = "MessageDto")]
    public class Message {
        /// <summary>
        /// The text content of the message.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        /// <summary>
        /// The message type.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// The timestamp string of the message.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }
        /// <summary>
        /// Indicates whether the message was sent by the owner.
        /// </summary>
        [JsonPropertyName("owner")]
        public bool Owner { get; set; }
        /// <summary>
        /// The current status of the message.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        /// <summary>
        /// The avatar URL of the sender.
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string? AvatarURL { get; set; }
        /// <summary>
        /// The assigned operator ID.
        /// </summary>
        [JsonPropertyName("assigned_id")]
        public string? AssignedID { get; set; }
        /// <summary>
        /// The operator&#39;s display name.
        /// </summary>
        [JsonPropertyName("operator_name")]
        public string? OperatorName { get; set; }
        /// <summary>
        /// Details of a failed message delivery, if any.
        /// </summary>
        [JsonPropertyName("failed_detail")]
        public string? FailedDetail { get; set; }
        /// <summary>
        /// The type of bot, if applicable.
        /// </summary>
        [JsonPropertyName("bot_type")]
        public string? BotType { get; set; }
        /// <summary>
        /// The local message identifier, can be used to track the message status.
        /// </summary>
        [JsonPropertyName("local_message_id")]
        public string? LocalMessageID { get; set; }
        /// <summary>
        /// The unique identifier of the conversation event.
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// The creation timestamp of the event.
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }
        /// <summary>
        /// The associated conversation identifier.
        /// </summary>
        [JsonPropertyName("conversation_id")]
        public string? ConversationID { get; set; }
        /// <summary>
        /// The associated ticket identifier.
        /// </summary>
        [JsonPropertyName("ticket_id")]
        public string? TicketID { get; set; }
        /// <summary>
        /// The type of event (e.g., message, ticket, broadcast).
        /// </summary>
        [JsonPropertyName("event_type")]
        public string? EventType { get; set; }
    }
}
