using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a base conversation event.
    /// </summary>
    [DataContract(Name = "ConversationEventDto")]
    public partial class ConversationEvent {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEvent" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the conversation event..</param>
        /// <param name="created">The creation timestamp of the event..</param>
        /// <param name="conversationID">The associated conversation identifier..</param>
        /// <param name="ticketID">The associated ticket identifier..</param>
        /// <param name="eventType">The type of event (e.g., message, ticket, broadcast)..</param>
        public ConversationEvent(string? id = null, DateTime created = default, string? conversationID = null, string? ticketID = null, string? eventType = null) {
            this.ID = id;
            this.Created = created;
            this.ConversationID = conversationID;
            this.TicketID = ticketID;
            this.EventType = eventType;
        }

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

        // not in WATI Api Schema...

        // GetMessages results
        [JsonPropertyName("event_description")]
        public string? EventDescription { get; set; }
        [JsonPropertyName("detailed_event_description")]
        public DetailedEventDescriptionType? DetailedEventDescription { get; set; }
        [JsonPropertyName("type")]
        public object? Type { get; set; }
        [JsonPropertyName("actor")]
        public string? Actor { get; set; }
        [JsonPropertyName("assignee")]
        public string? Assignee { get; set; }
        [JsonPropertyName("topic_name")]
        public string? TopicName { get; set; }
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }
        [JsonPropertyName("owner")]
        public bool? Owner { get; set; }
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("final_text")]
        public string? FinalText { get; set; }
        [JsonPropertyName("failed_detail")]
        public string? FailedDetail { get; set; }
        [JsonPropertyName("status_string")]
        public string? StatusString { get; set; }
        public class DetailedEventDescriptionType {
            [JsonPropertyName("type")]
            public int? Type { get; set; }
            [JsonPropertyName("actor")]
            public string? Actor { get; set; }
            [JsonPropertyName("agent_name")]
            public string? AgentName { get; set; }
        }

        // SendText response
        [JsonPropertyName("assigned_id")]
        public string? AssignedID { get; set; }
        [JsonPropertyName("local_message_id")]
        public string? LocalMessageID { get; set; }
    }
}
