using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a language option for a message template.
    /// </summary>
    [DataContract(Name = "LanguageOptionDto")]
    public partial class LanguageOption {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageOption" /> class.
        /// </summary>
        /// <param name="key">The language key identifier..</param>
        /// <param name="value">The language value..</param>
        /// <param name="text">The display text for the language option..</param>
        public LanguageOption(string? key = null, string? value = null, string? text = null) {
            this.Key = key;
            this.Value = value;
            this.Text = text;
        }

        /// <summary>
        /// The language key identifier.
        /// </summary>
        /// <value>The language key identifier.</value>
        [JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The language value.
        /// </summary>
        /// <value>The language value.</value>
        [JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The display text for the language option.
        /// </summary>
        /// <value>The display text for the language option.</value>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}
