using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting broadcasts overview.
    /// </summary>
    [DataContract(Name = "GetBroadcastsOverviewResponse")]
    public class GetBroadcastsOverviewResponse {
        /// <summary>
        /// The total number of links.
        /// </summary>
        [JsonPropertyName("total_links")]
        public long TotalLinks { get; set; }
        /// <summary>
        /// The total number of processing links.
        /// </summary>
        [JsonPropertyName("total_processing")]
        public long TotalProcessing { get; set; }
        /// <summary>
        /// The total number of queued links.
        /// </summary>
        [JsonPropertyName("total_queued")]
        public long TotalQueued { get; set; }
        /// <summary>
        /// The total number of sent links.
        /// </summary>
        [JsonPropertyName("total_sent")]
        public long TotalSent { get; set; }
        /// <summary>
        /// The total number of delivered links.
        /// </summary>
        [JsonPropertyName("total_delivered")]
        public long TotalDelivered { get; set; }
        /// <summary>
        /// The total number of open links.
        /// </summary>
        [JsonPropertyName("total_open")]
        public long TotalOpen { get; set; }
        /// <summary>
        /// The total number of replied links.
        /// </summary>
        [JsonPropertyName("total_replied")]
        public long TotalReplied { get; set; }
        /// <summary>
        /// The total number of failed links.
        /// </summary>
        [JsonPropertyName("total_failed")]
        public long TotalFailed { get; set; }
        /// <summary>
        /// The total number of stopped links.
        /// </summary>
        [JsonPropertyName("total_stopped")]
        public long TotalStopped { get; set; }
        /// <summary>
        /// The total number of sending links.
        /// </summary>
        [JsonPropertyName("total_sending")]
        public long TotalSending { get; set; }
    }
}
