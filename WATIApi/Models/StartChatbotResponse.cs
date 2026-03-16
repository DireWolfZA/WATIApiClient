using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for starting a chatbot.
    /// </summary>
    [DataContract(Name = "StartChatbotResponse")]
    public partial class StartChatbotResponse {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartChatbotResponse" /> class.
        /// </summary>
        /// <param name="result">Result of the chatbot start operation..</param>
        public StartChatbotResponse(bool result = default) {
            this.Result = result;
        }

        /// <summary>
        /// Result of the chatbot start operation.
        /// </summary>
        /// <value>Result of the chatbot start operation.</value>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
