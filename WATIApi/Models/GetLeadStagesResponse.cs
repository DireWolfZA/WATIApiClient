using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting lead stages.
    /// </summary>
    [DataContract(Name = "GetLeadStagesResponse")]
    public partial class GetLeadStagesResponse {
        /// <summary>
        /// The list of lead stages.
        /// </summary>
        [JsonPropertyName("stages")]
        public List<LeadStageItem>? Stages { get; set; }
    }
}
