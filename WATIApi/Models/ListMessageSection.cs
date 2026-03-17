using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a section in the list message.
    /// </summary>
    [DataContract(Name = "ListMessageSectionDto")]
    public partial class ListMessageSection {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMessageSection" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="rows">rows.</param>
        public ListMessageSection(string? title = null, List<ListMessageSectionRow>? rows = null) {
            this.Title = title;
            this.Rows = rows;
        }

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
