using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting contact count.
    /// </summary>
    [DataContract(Name = "GetContactCountResponse")]
    public partial class GetContactCountResponse {
        /// <summary>
        /// The contact count.
        /// </summary>
        /// <value>The contact count.</value>
        [JsonPropertyName("contact_count")]
        public long ContactCount { get; set; }
    }
}
