using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a lead stage item.
    /// </summary>
    [DataContract(Name = "LeadStageItemDto")]
    public class LeadStageItem {
        /// <summary>
        /// The unique identifier of the lead stage.
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// The display label of the lead stage.
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        /// <summary>
        /// The color code of the lead stage in hex format.
        /// </summary>
        [JsonPropertyName("color")]
        public string? Color { get; set; }
        /// <summary>
        /// The sort order of the lead stage.
        /// </summary>
        [JsonPropertyName("sort_order")]
        public int SortOrder { get; set; }
    }
}
