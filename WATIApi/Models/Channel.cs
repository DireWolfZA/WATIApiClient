using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a channel object.
    /// </summary>
    [DataContract(Name = "ChannelDto")]
    public partial class Channel {
        /// <summary>
        /// Initializes a new instance of the <see cref="Channel" /> class.
        /// </summary>
        /// <param name="id">The identifier of channel.</param>
        /// <param name="name">The custom name of channel.</param>
        /// <param name="platform">The platform of channel.</param>
        public Channel(string? id = null, string? name = null, string? platform = null) {
            this.ID = id;
            this.Name = name;
            this.Platform = platform;
        }

        /// <summary>
        /// The identifier of channel
        /// </summary>
        /// <value>The identifier of channel</value>
        [JsonPropertyName("id")]
        public string? ID { get; set; }

        /// <summary>
        /// The custom name of channel
        /// </summary>
        /// <value>The custom name of channel</value>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The platform of channel
        /// </summary>
        /// <value>The platform of channel</value>
        [JsonPropertyName("channel")]
        public string? Platform { get; set; }
    }
}
