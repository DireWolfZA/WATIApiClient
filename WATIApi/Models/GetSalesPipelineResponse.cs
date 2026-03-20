using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting sales pipeline.
    /// </summary>
    [DataContract(Name = "GetSalesPipelineResponse")]
    public class GetSalesPipelineResponse {
        /// <summary>
        /// The overall win rate as a percentage.
        /// </summary>
        [JsonPropertyName("win_rate")]
        public double WinRate { get; set; }
        /// <summary>
        /// The list of stage pipeline entries.
        /// </summary>
        [JsonPropertyName("entries")]
        public List<StagePipeline>? Entries { get; set; }
    }
}
