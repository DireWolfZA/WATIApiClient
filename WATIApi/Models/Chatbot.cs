using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a chatbot with basic information.
    /// </summary>
    [DataContract(Name = "ChatbotDto")]
    public partial class Chatbot {
        /// <summary>
        /// Initializes a new instance of the <see cref="Chatbot" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the chatbot..</param>
        /// <param name="name">The name of the chatbot..</param>
        /// <param name="created">The date and time when the chatbot was created..</param>
        public Chatbot(string? id = null, string? name = null, DateTime created = default) {
            this.ID = id;
            this.Name = name;
            this.Created = created;
        }

        /// <summary>
        /// The unique identifier of the chatbot.
        /// </summary>
        /// <value>The unique identifier of the chatbot.</value>
        [JsonPropertyName("id")]
        public string? ID { get; set; }

        /// <summary>
        /// The name of the chatbot.
        /// </summary>
        /// <value>The name of the chatbot.</value>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The date and time when the chatbot was created.
        /// </summary>
        /// <value>The date and time when the chatbot was created.</value>
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }
    }
}
