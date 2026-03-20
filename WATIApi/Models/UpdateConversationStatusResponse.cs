using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for updating conversation status.
    /// </summary>
    [DataContract(Name = "UpdateConversationStatusResponse")]
    public class UpdateConversationStatusResponse {
        /// <summary>
        /// Updated result
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
