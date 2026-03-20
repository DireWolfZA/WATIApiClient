using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a stage pipeline entry.
    /// </summary>
    [DataContract(Name = "StagePipelineDto")]
    public class StagePipeline {
        /// <summary>
        /// The name of the stage.
        /// </summary>
        [JsonPropertyName("stage")]
        public string? Stage { get; set; }
        /// <summary>
        /// The count of leads in this stage.
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
