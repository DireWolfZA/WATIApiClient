using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a section in the list message.
    /// </summary>
    [DataContract(Name = "ListMessageSectionDto")]
    public class ListMessageSection {
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        /// <summary>
        /// Gets or Sets Rows
        /// </summary>
        [JsonPropertyName("rows")]
        public List<ListMessageSectionRow>? Rows { get; set; }
    }
}
