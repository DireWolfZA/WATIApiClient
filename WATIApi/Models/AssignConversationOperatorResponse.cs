using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for assigning a conversation operator.
    /// </summary>
    [DataContract(Name = "AssignConversationOperatorResponse")]
    public class AssignConversationOperatorResponse {
        /// <summary>
        /// Assign result
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
