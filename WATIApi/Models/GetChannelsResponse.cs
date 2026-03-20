using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting channels.
    /// </summary>
    [DataContract(Name = "GetChannelsResponse")]
    public class GetChannelsResponse {
        /// <summary>
        /// The list of channel info.
        /// </summary>
        [JsonPropertyName("channels")]
        public List<Channel>? Channels { get; set; }
    }
}
