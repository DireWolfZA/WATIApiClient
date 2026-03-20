using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for assigning a conversation operator.
    /// </summary>
    [DataContract(Name = "AssignConversationOperatorRequest")]
    public class AssignConversationOperatorRequest {
        /// <param name="assigneeEmail">Email of the assignee. If not provided, the conversation will be assigned to the bot operator.</param>
        public AssignConversationOperatorRequest(string? assigneeEmail) {
            this.AssigneeEmail = assigneeEmail;
        }

        /// <summary>
        /// Email of the assignee. If not provided, the conversation will be assigned to the bot operator.
        /// </summary>
        [JsonPropertyName("assignee_email")]
        public string? AssigneeEmail { get; set; }
    }
}
