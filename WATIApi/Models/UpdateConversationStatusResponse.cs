using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for updating conversation status.
    /// </summary>
    [DataContract(Name = "UpdateConversationStatusResponse")]
    public partial class UpdateConversationStatusResponse {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationStatusResponse" /> class.
        /// </summary>
        /// <param name="result">Updated result.</param>
        public UpdateConversationStatusResponse(bool result) {
            this.Result = result;
        }

        /// <summary>
        /// Updated result
        /// </summary>
        /// <value>Updated result</value>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
