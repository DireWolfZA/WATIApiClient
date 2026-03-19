using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Request model for getting the sales pipeline.
    /// </summary>
    [DataContract(Name = "GetSalesPipelineRequest")]
    public partial class GetSalesPipelineRequest {
        /// <summary>
        /// The start date to get the sales pipeline in ISO 8601 format of UTC timezone.
        /// </summary>
        [JsonPropertyName("from")]
        public DateTime From { get; set; }
        /// <summary>
        /// The end date to get the sales pipeline in ISO 8601 format of UTC timezone.
        /// </summary>
        [JsonPropertyName("to")]
        public DateTime To { get; set; }
        /// <summary>
        /// The list of agent IDs. Each ID must be a valid ObjectID. Note: Set agentIds to null or exclude it to include all agents in the results.
        /// </summary>
        [JsonPropertyName("agentIds")]
        public List<string>? AgentIDs { get; set; }
        /// <summary>
        /// The list of stage IDs to filter. Note: Set stageIDs to null or exclude it to include all stages in the results.
        /// </summary>
        [JsonPropertyName("selectedStageIds")]
        public List<string>? SelectedStageIDs { get; set; }
    }
}
