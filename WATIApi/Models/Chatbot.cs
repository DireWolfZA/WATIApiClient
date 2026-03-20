using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a chatbot with basic information.
    /// </summary>
    [DataContract(Name = "ChatbotDto")]
    public class Chatbot {
        /// <summary>
        /// The unique identifier of the chatbot.
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// The name of the chatbot.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// The date and time when the chatbot was created.
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }
    }
}
