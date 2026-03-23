using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    public interface IWATIEvent {
        /// <summary>
        /// Identifies the type of webhook event being triggered
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
    }

    public interface IWATIEventWithID : IWATIEvent {
        [JsonPropertyName("id")]
        public string? ID { get; set; }
    }
    public interface IWATIEventWithMessageID : IWATIEventWithID {
        /// <summary>
        /// WhatsApp's unique message identifier (WAMID)
        /// </summary>
        [JsonPropertyName("whatsappMessageId")]
        public string? WhatsAppMessageID { get; set; }
    }

    public interface IWATIEventWithWABAID : IWATIEvent {
        /// <summary>
        /// Unique identifier for the WhatsApp Business Account
        /// </summary>
        [JsonPropertyName("wabaId")]
        public string? WABA_ID { get; set; }
    }
}
