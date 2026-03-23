using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/template-category-update
    public class TemplateCategoryUpdate {
        /// <summary>
        /// The type of webhook event. Always "templateCategoryUpdated" for this event.
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// The Meta template identifier used by Facebook/WhatsApp.
        /// </summary>
        [JsonPropertyName("templateId")]
        public string? TemplateID { get; set; }
        /// <summary>
        /// The WhatsApp Business Account ID associated with the template.
        /// </summary>
        [JsonPropertyName("wabaId")]
        public string? WABA_ID { get; set; }
        /// <summary>
        /// The name of the message template that was updated.
        /// </summary>
        [JsonPropertyName("templateName")]
        public string? TemplateName { get; set; }
        /// <summary>
        /// The internal template identifier used by Wati.
        /// </summary>
        [JsonPropertyName("watiTemplateId")]
        public string? WATITemplateID { get; set; }
        /// <summary>
        /// The previous category of the template. See template categories for available values.
        /// </summary>
        [JsonPropertyName("oldTemplateCategory")]
        public string? OldTemplateCategory { get; set; }
        /// <summary>
        /// The new category assigned to the template. See template categories for available values.
        /// </summary>
        [JsonPropertyName("newTemplateCategory")]
        public string? NewTemplateCategory { get; set; }
        /// <summary>
        /// The channel identifier. Can be null if not associated with a specific channel.
        /// </summary>
        [JsonPropertyName("channelId")]
        public string? ChannelID { get; set; }
        /// <summary>
        /// The phone number associated with the WhatsApp Business Account channel.
        /// </summary>
        [JsonPropertyName("channelPhoneNumber")]
        public string? ChannelPhoneNumber { get; set; }
    }
}
