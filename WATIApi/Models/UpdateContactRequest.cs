using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Individual contact update request.
    /// </summary>
    [DataContract(Name = "UpdateContactRequest")]
    public class UpdateContactRequest {
        /// <summary>
        /// The target contact in the following formats:
        /// <br />* &#x60;ContactId&#x60;: The unique ID of a contact.
        /// <br />* &#x60;PhoneNumber&#x60;: The contact&#39;s phone number (e.g., &#x60;14155552671&#x60;).
        /// <br />* &#x60;Channel:PhoneNumber&#x60;: A combination of the channel (name or phone number) and the recipient&#39;s phone number (e.g., &#x60;MyChannel:1415552671&#x60;, &#x60;123456789:1415552671&#x60;).
        /// </summary>
        [JsonPropertyName("target")]
        public required string? Target { get; set; }
        /// <summary>
        /// Custom parameters of the contact.
        /// </summary>
        [JsonPropertyName("customParams")]
        public List<CustomParam>? CustomParams { get; set; }
    }
}
