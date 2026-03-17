using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a message event within a conversation.
    /// </summary>
    [DataContract(Name = "MessageDto")]
    public partial class Message {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="text">The text content of the message..</param>
        /// <param name="type">The message type..</param>
        /// <param name="timestamp">The timestamp string of the message..</param>
        /// <param name="owner">Indicates whether the message was sent by the owner..</param>
        /// <param name="status">The current status of the message..</param>
        /// <param name="avatarURL">The avatar URL of the sender..</param>
        /// <param name="assignedID">The assigned operator ID..</param>
        /// <param name="operatorName">The operator&#39;s display name..</param>
        /// <param name="failedDetail">Details of a failed message delivery, if any..</param>
        /// <param name="botType">The type of bot, if applicable..</param>
        /// <param name="localMessageID">The local message identifier, can be used to track the message status..</param>
        /// <param name="id">The unique identifier of the conversation event..</param>
        /// <param name="created">The creation timestamp of the event..</param>
        /// <param name="conversationID">The associated conversation identifier..</param>
        /// <param name="ticketID">The associated ticket identifier..</param>
        /// <param name="eventType">The type of event (e.g., message, ticket, broadcast)..</param>
        public Message(string? text = null, string? type = null, string? timestamp = null, bool owner = default, string? status = null, string? avatarURL = null, string? assignedID = null, string? operatorName = null, string? failedDetail = null, string? botType = null, string? localMessageID = null, string? id = null, DateTime created = default, string? conversationID = null, string? ticketID = null, string? eventType = null) {
            this.Text = text;
            this.Type = type;
            this.Timestamp = timestamp;
            this.Owner = owner;
            this.Status = status;
            this.AvatarURL = avatarURL;
            this.AssignedID = assignedID;
            this.OperatorName = operatorName;
            this.FailedDetail = failedDetail;
            this.BotType = botType;
            this.LocalMessageID = localMessageID;
            this.ID = id;
            this.Created = created;
            this.ConversationID = conversationID;
            this.TicketID = ticketID;
            this.EventType = eventType;
        }

        /// <summary>
        /// The text content of the message.
        /// </summary>
        /// <value>The text content of the message.</value>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The message type.
        /// </summary>
        /// <value>The message type.</value>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The timestamp string of the message.
        /// </summary>
        /// <value>The timestamp string of the message.</value>
        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Indicates whether the message was sent by the owner.
        /// </summary>
        /// <value>Indicates whether the message was sent by the owner.</value>
        [JsonPropertyName("owner")]
        public bool Owner { get; set; }

        /// <summary>
        /// The current status of the message.
        /// </summary>
        /// <value>The current status of the message.</value>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The avatar URL of the sender.
        /// </summary>
        /// <value>The avatar URL of the sender.</value>
        [JsonPropertyName("avatar_url")]
        public string? AvatarURL { get; set; }

        /// <summary>
        /// The assigned operator ID.
        /// </summary>
        /// <value>The assigned operator ID.</value>
        [JsonPropertyName("assigned_id")]
        public string? AssignedID { get; set; }

        /// <summary>
        /// The operator&#39;s display name.
        /// </summary>
        /// <value>The operator&#39;s display name.</value>
        [JsonPropertyName("operator_name")]
        public string? OperatorName { get; set; }

        /// <summary>
        /// Details of a failed message delivery, if any.
        /// </summary>
        /// <value>Details of a failed message delivery, if any.</value>
        [JsonPropertyName("failed_detail")]
        public string? FailedDetail { get; set; }

        /// <summary>
        /// The type of bot, if applicable.
        /// </summary>
        /// <value>The type of bot, if applicable.</value>
        [JsonPropertyName("bot_type")]
        public string? BotType { get; set; }

        /// <summary>
        /// The local message identifier, can be used to track the message status.
        /// </summary>
        /// <value>The local message identifier, can be used to track the message status.</value>
        [JsonPropertyName("local_message_id")]
        public string? LocalMessageID { get; set; }

        /// <summary>
        /// The unique identifier of the conversation event.
        /// </summary>
        /// <value>The unique identifier of the conversation event.</value>
        [JsonPropertyName("id")]
        public string? ID { get; set; }

        /// <summary>
        /// The creation timestamp of the event.
        /// </summary>
        /// <value>The creation timestamp of the event.</value>
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The associated conversation identifier.
        /// </summary>
        /// <value>The associated conversation identifier.</value>
        [JsonPropertyName("conversation_id")]
        public string? ConversationID { get; set; }

        /// <summary>
        /// The associated ticket identifier.
        /// </summary>
        /// <value>The associated ticket identifier.</value>
        [JsonPropertyName("ticket_id")]
        public string? TicketID { get; set; }

        /// <summary>
        /// The type of event (e.g., message, ticket, broadcast).
        /// </summary>
        /// <value>The type of event (e.g., message, ticket, broadcast).</value>
        [JsonPropertyName("event_type")]
        public string? EventType { get; set; }
    }
}
