using System;
using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    /// <summary>Select `Payment Captured` event type</summary>
    public class PaymentCaptured : IWATIEventWithID {
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        [JsonPropertyName("from")]
        public string? From { get; set; }
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("created")]
        public DateTime? Created { get; set; }

        [JsonPropertyName("payment")]
        public PaymentClass? Payment { get; set; }
        public class PaymentClass {
            [JsonPropertyName("referenceId")]
            public string? ReferenceID { get; set; }
            [JsonPropertyName("sender")]
            public string? Sender { get; set; }
        }

        [JsonPropertyName("id")]
        public string? ID { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
