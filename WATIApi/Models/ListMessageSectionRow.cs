using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a row in a list message section.
    /// </summary>
    [DataContract(Name = "ListMessageSectionRowDto")]
    public partial class ListMessageSectionRow {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMessageSectionRow" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        public ListMessageSectionRow(string? title = null, string? description = null) {
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
