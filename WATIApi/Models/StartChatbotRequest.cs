using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for starting a chatbot.
    /// </summary>
    [DataContract(Name = "StartChatbotRequest")]
    public class StartChatbotRequest {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartChatbotRequest" /> class.
        /// </summary>
        /// <param name="target">
        /// The target recipient in the following formats:
        /// <br />* &#x60;ContactId&#x60;: The unique ID of a contact.
        /// <br />* &#x60;PhoneNumber&#x60;: The recipient&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:ContactId&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:65b73810e2bd04aa867b5f7d&#x60;, &#x60;123456789:65b73810e2bd04aa867b5f7d&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;). (required).
        /// </param>
        /// <param name="chatbotID">Chatbot ID. (required).</param>
        public StartChatbotRequest(string target, string chatbotID) {
            this.Target = target;
            this.ChatbotID = chatbotID;
        }

        /// <summary>
        /// The target recipient in the following formats:
        /// <br />* &#x60;ContactID&#x60;: The unique ID of a contact.
        /// <br />* &#x60;PhoneNumber&#x60;: The recipient&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:ContactID&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:65b73810e2bd04aa867b5f7d&#x60;, &#x60;123456789:65b73810e2bd04aa867b5f7d&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; }
        /// <summary>
        /// Chatbot ID.
        /// </summary>
        /// <value>Chatbot ID.</value>
        [JsonPropertyName("chatbot_id")]
        public string ChatbotID { get; set; }
    }
}
