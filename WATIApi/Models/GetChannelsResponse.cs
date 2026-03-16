using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting channels.
    /// </summary>
    [DataContract(Name = "GetChannelsResponse")]
    public partial class GetChannelsResponse {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelsResponse" /> class.
        /// </summary>
        /// <param name="channels">The list of channel info..</param>
        public GetChannelsResponse(List<Channel>? channels = null) {
            this.Channels = channels;
        }

        /// <summary>
        /// The list of channel info.
        /// </summary>
        /// <value>The list of channel info.</value>
        [JsonPropertyName("channels")]
        public List<Channel>? Channels { get; set; }
    }
}
