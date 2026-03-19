using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a product error.
    /// </summary>
    [DataContract(Name = "ProductErrorDto")]
    public partial class ProductError {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductError" /> class.
        /// </summary>
        /// <param name="title">The error title..</param>
        /// <param name="type">The error type..</param>
        public ProductError(string? title = null, string? type = null) {
            this.Title = title;
            this.Type = type;
        }

        /// <summary>
        /// The error title.
        /// </summary>
        /// <value>The error title.</value>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The error type.
        /// </summary>
        /// <value>The error type.</value>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
