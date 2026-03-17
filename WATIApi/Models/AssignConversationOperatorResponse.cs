using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for assigning a conversation operator.
    /// </summary>
    [DataContract(Name = "AssignConversationOperatorResponse")]
    public partial class AssignConversationOperatorResponse {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignConversationOperatorResponse" /> class.
        /// </summary>
        /// <param name="result">Assign result.</param>
        public AssignConversationOperatorResponse(bool result) {
            this.Result = result;
        }

        /// <summary>
        /// Assign result
        /// </summary>
        /// <value>Assign result</value>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
