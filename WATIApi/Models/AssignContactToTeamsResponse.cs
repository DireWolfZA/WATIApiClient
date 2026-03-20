using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for assigning a contact to teams.
    /// </summary>
    [DataContract(Name = "AssignContactToTeamsResponse")]
    public class AssignContactToTeamsResponse {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignContactToTeamsResponse" /> class.
        /// </summary>
        /// <param name="result">Result of the team assignment operation.</param>
        public AssignContactToTeamsResponse(bool result = default) {
            this.Result = result;
        }

        /// <summary>
        /// Result of the team assignment operation.
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
