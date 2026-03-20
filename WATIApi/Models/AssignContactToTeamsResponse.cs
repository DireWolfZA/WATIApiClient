using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for assigning a contact to teams.
    /// </summary>
    [DataContract(Name = "AssignContactToTeamsResponse")]
    public class AssignContactToTeamsResponse {
        /// <summary>
        /// Result of the team assignment operation.
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
