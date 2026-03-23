using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/template-status-update
    public class TemplateStatusUpdate {
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
        /// The previous status of the template before the update. See status codes below.
        /// <br />1.DRAFT,
        /// <br />2.PENDING,
        /// <br />3.APPROVED,
        /// <br />4.REJECTED,
        /// <br />5.DELETED,
        /// <br />6.PENDING_INTERNAL,
        /// <br />7.DISABLED,
        /// <br />8.PAUSED
        /// </summary>
        [JsonPropertyName("oldTemplateStatus")]
        public int? OldTemplateStatus { get; set; }
        /// <summary>
        /// The updated status of the template after the review. See status codes below.
        /// <br />1.DRAFT,
        /// <br />2.PENDING,
        /// <br />3.APPROVED,
        /// <br />4.REJECTED,
        /// <br />5.DELETED,
        /// <br />6.PENDING_INTERNAL,
        /// <br />7.DISABLED,
        /// <br />8.PAUSED
        /// </summary>
        [JsonPropertyName("newTemplateStatus")]
        public int? NewTemplateStatus { get; set; }
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
}
