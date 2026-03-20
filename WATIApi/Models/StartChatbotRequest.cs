using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for starting a chatbot.
    /// </summary>
    [DataContract(Name = "StartChatbotRequest")]
    public class StartChatbotRequest {
        /// <summary>
        /// The target recipient in the following formats:
        /// <br />* &#x60;ContactID&#x60;: The unique ID of a contact.
        /// <br />* &#x60;PhoneNumber&#x60;: The recipient&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:ContactID&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:65b73810e2bd04aa867b5f7d&#x60;, &#x60;123456789:65b73810e2bd04aa867b5f7d&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </summary>
        [JsonPropertyName("target")]
        public required string Target { get; set; }
        /// <summary>
        /// Chatbot ID.
        /// </summary>
        [JsonPropertyName("chatbot_id")]
        public required string ChatbotID { get; set; }
    }
}
