using System.Text.Json.Serialization;

namespace WATIApi.Webhooks {
    //https://docs.wati.io/reference/waba-account-content-updated
    public class WABAAccountContentUpdated : IWATIEventWithWABAID {
        /// <summary>
        /// Always set to "accountUpdated" to identify this event type
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }
        /// <summary>
        /// Unique identifier for the WhatsApp Business Account
        /// </summary>
        [JsonPropertyName("wabaId")]
        public string? WABA_ID { get; set; }
        /// <summary>
        /// Specific event details or trigger that caused the account update
        /// </summary>
        [JsonPropertyName("event")]
        public string? Event { get; set; }
        /// <summary>
        /// Container for violation-related information (if applicable)
        /// </summary>
        [JsonPropertyName("violationInfo")]
        public ViolationInfoClass? ViolationInfo { get; set; }
        public class ViolationInfoClass {
            /// <summary>
            /// Type of policy violation detected on the account
            /// </summary>
            [JsonPropertyName("violation_type")]
            public string? ViolationType { get; set; }
        }
        /// <summary>
        /// Container for ban-related information (if applicable)
        /// </summary>
        [JsonPropertyName("banInfo")]
        public BanInfoClass? BanInfo { get; set; }
        public class BanInfoClass {
            /// <summary>
            /// Current ban status of the WABA (e.g., "banned", "restricted", "active")
            /// </summary>
            [JsonPropertyName("waba_ban_state")]
            public string? BanState { get; set; }
            /// <summary>
            /// Date when the ban was applied (ISO 8601 format)
            /// </summary>
            [JsonPropertyName("waba_ban_date")]
            public string? BanDate { get; set; }
        }
    }
}
