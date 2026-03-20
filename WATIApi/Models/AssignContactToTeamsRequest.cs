using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for assigning a contact to teams.
    /// </summary>
    [DataContract(Name = "AssignContactToTeamsRequest")]
    public class AssignContactToTeamsRequest {
        /// <param name="target">
        /// The target contact in the following formats:
        /// <br />* &#x60;ContactID&#x60;: The unique ID of a contact.
        /// <br />* &#x60;PhoneNumber&#x60;: The contact&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </param>
        /// <param name="teams">List of teams to assign.</param>
        public AssignContactToTeamsRequest(string target, List<string> teams) {
            this.Target = target;
            this.Teams = teams;
        }

        /// <summary>
        /// The target contact in the following formats:
        /// <br />* &#x60;ContactID&#x60;: The unique ID of a contact.
        /// <br />* &#x60;PhoneNumber&#x60;: The contact&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; }
        /// <summary>
        /// List of teams to assign.
        /// </summary>
        [JsonPropertyName("teams")]
        public List<string> Teams { get; set; }
    }
}
