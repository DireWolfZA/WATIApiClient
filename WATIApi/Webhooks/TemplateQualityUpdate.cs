using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/template-quality-update
    public class TemplateQualityUpdate : IWATIEventWithWABAID {
        /// <summary>
        /// The type of webhook event. Always "templateQualityUpdated" for this event.
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// The Meta template identifier for the WhatsApp Business template.
        /// </summary>
        [JsonPropertyName("templateId")]
        public string? TemplateID { get; set; }
        /// <summary>
        /// The WhatsApp Business Account identifier associated with the template.
        /// </summary>
        [JsonPropertyName("wabaId")]
        public string? WABA_ID { get; set; }
        /// <summary>
        /// The name of the WhatsApp message template whose quality was updated.
        /// </summary>
        [JsonPropertyName("templateName")]
        public string? TemplateName { get; set; }
        /// <summary>
        /// The internal Wati template identifier for tracking purposes.
        /// </summary>
        [JsonPropertyName("watiTemplateId")]
        public string? WATITemplateID { get; set; }

        /// <summary>
        /// The previous quality rating of the template before the update.
        /// </summary>
        [JsonPropertyName("oldTemplateQuality")]
        public EOldTemplateQuality? OldTemplateQuality { get; set; }
        public enum EOldTemplateQuality : int {
            /// <summary>Indicates quality pending.</summary>
            Unknown = 0,
            /// <summary>Indicates high quality.</summary>
            Green = 1,
            /// <summary>Indicates low quality.</summary>
            Red = 2,
            /// <summary>Indicates medium quality.</summary>
            Yellow = 3,
        }

        /// <summary>
        /// The updated quality rating of the template.
        /// </summary>
        [JsonPropertyName("newTemplateQuality")]
        public int? NewTemplateQuality { get; set; }
        public enum ENewTemplateQuality : int {
            ///<summary>Indicates quality pending.</summary>
            Unknown = 1,
            ///<summary>Indicates high quality.</summary>
            Green = 2,
            ///<summary>Indicates low quality.</summary>
            Red = 3,
            ///<summary>Indicates medium quality.</summary>
            Yellow = 0,
        }

        /// <summary>
        /// The identifier of the channel associated with the template. Can be null if not applicable.
        /// </summary>
        [JsonPropertyName("channelId")]
        public string? ChannelID { get; set; }
        /// <summary>
        /// The phone number associated with the WhatsApp Business channel.
        /// </summary>
        [JsonPropertyName("channelPhoneNumber")]
        public string? ChannelPhoneNumber { get; set; }
    }
}
