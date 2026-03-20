using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a channel object.
    /// </summary>
    [DataContract(Name = "ChannelDto")]
    public class Channel {
        /// <summary>
        /// The identifier of channel
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// The custom name of channel
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// The platform of channel
        /// </summary>
        [JsonPropertyName("channel")]
        public string? Platform { get; set; }
    }
}
