using System;
using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    /// <summary>Select `CTA Button Clicked` event type</summary>
    public class CTAButtonClicked : IWATIEventWithMessageID {
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        [JsonPropertyName("localMessageId")]
        public string? LocalMessageID { get; set; }
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        [JsonPropertyName("whatsappMessageId")]
        public string? WhatsAppMessageID { get; set; }
        [JsonPropertyName("templateId")]
        public string? TemplateID { get; set; }
        [JsonPropertyName("templateName")]
        public string? TemplateName { get; set; }
        [JsonPropertyName("created")]
        public DateTime? Created { get; set; }
        [JsonPropertyName("conversationId")]
        public string? ConversationID { get; set; }
        [JsonPropertyName("ticketId")]
        public string? TicketID { get; set; }
        [JsonPropertyName("displayText")]
        public string? DisplayText { get; set; }
        [JsonPropertyName("buttonUrl")]
        public string? ButtonURL { get; set; }
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        [JsonPropertyName("operatorEmail")]
        public string? OperatorEmail { get; set; }
        [JsonPropertyName("waId")]
        public string? WA_ID { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("statusString")]
        public string? StatusString { get; set; }
        [JsonPropertyName("sourceType")]
        public string? SourceType { get; set; }
    }
}
