using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a product error.
    /// </summary>
    [DataContract(Name = "ProductErrorDto")]
    public class ProductError {
        /// <summary>
        /// The error title.
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        /// <summary>
        /// The error type.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
