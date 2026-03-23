using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/template-status-update
    public class TemplateStatusUpdate : IWATIEventWithWABAID {
        /// <summary>
        /// The type of webhook event. Always "templateReviewed" for this event.
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// WhatsApp Business Account ID associated with the template.
        /// </summary>
        [JsonPropertyName("wabaId")]
        public string? WABA_ID { get; set; }
        /// <summary>
        /// The name of the WhatsApp message template.
        /// </summary>
        [JsonPropertyName("templateName")]
        public string? TemplateName { get; set; }
        /// <summary>
        /// Meta's unique identifier for the template.
        /// </summary>
        [JsonPropertyName("templateId")]
        public string? TemplateID { get; set; }
        /// <summary>
        /// Wati's internal unique identifier for the template.
        /// </summary>
        [JsonPropertyName("watiTemplateId")]
        public string? WATITemplateID { get; set; }
        /// <summary>
        /// The previous status of the template before the update.
        /// </summary>
        [JsonPropertyName("oldTemplateStatus")]
        public TemplateStatus? OldTemplateStatus { get; set; }
        /// <summary>
        /// The updated status of the template after the review.
        /// </summary>
        [JsonPropertyName("newTemplateStatus")]
        public TemplateStatus? NewTemplateStatus { get; set; }
        /// <summary>
        /// Channel identifier. May be null if not applicable.
        /// </summary>
        [JsonPropertyName("channelId")]
        public string? ChannelID { get; set; }
        /// <summary>
        /// Phone number associated with the WhatsApp Business channel.
        /// </summary>
        [JsonPropertyName("channelPhoneNumber")]
        public string? ChannelPhoneNumber { get; set; }
    }

    public enum TemplateStatus : int {
        Draft = 1,
        Pending = 2,
        Approved = 3,
        Rejected = 4,
        Deleted = 5,
        PendingInternal = 6,
        Disabled = 7,
        Paused = 8,
    }
}
