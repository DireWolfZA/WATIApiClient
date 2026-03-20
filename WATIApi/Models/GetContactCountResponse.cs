using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting contact count.
    /// </summary>
    [DataContract(Name = "GetContactCountResponse")]
    public class GetContactCountResponse {
        /// <summary>
        /// The contact count.
        /// </summary>
        [JsonPropertyName("contact_count")]
        public long ContactCount { get; set; }
    }
}
