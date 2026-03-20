using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a language option for a message template.
    /// </summary>
    [DataContract(Name = "LanguageOptionDto")]
    public class LanguageOption {
        /// <summary>
        /// The language key identifier.
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; }
        /// <summary>
        /// The language value.
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        /// <summary>
        /// The display text for the language option.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}
