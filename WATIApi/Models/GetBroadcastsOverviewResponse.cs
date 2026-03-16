using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Response model for getting broadcasts overview.
    /// </summary>
    [DataContract(Name = "GetBroadcastsOverviewResponse")]
    public partial class GetBroadcastsOverviewResponse {
        /// <summary>
        /// The total number of links.
        /// </summary>
        /// <value>The total number of links.</value>
        [JsonPropertyName("total_links")]
        public long TotalLinks { get; set; }

        /// <summary>
        /// The total number of processing links.
        /// </summary>
        /// <value>The total number of processing links.</value>
        [JsonPropertyName("total_processing")]
        public long TotalProcessing { get; set; }

        /// <summary>
        /// The total number of queued links.
        /// </summary>
        /// <value>The total number of queued links.</value>
        [JsonPropertyName("total_queued")]
        public long TotalQueued { get; set; }

        /// <summary>
        /// The total number of sent links.
        /// </summary>
        /// <value>The total number of sent links.</value>
        [JsonPropertyName("total_sent")]
        public long TotalSent { get; set; }

        /// <summary>
        /// The total number of delivered links.
        /// </summary>
        /// <value>The total number of delivered links.</value>
        [JsonPropertyName("total_delivered")]
        public long TotalDelivered { get; set; }

        /// <summary>
        /// The total number of open links.
        /// </summary>
        /// <value>The total number of open links.</value>
        [JsonPropertyName("total_open")]
        public long TotalOpen { get; set; }

        /// <summary>
        /// The total number of replied links.
        /// </summary>
        /// <value>The total number of replied links.</value>
        [JsonPropertyName("total_replied")]
        public long TotalReplied { get; set; }

        /// <summary>
        /// The total number of failed links.
        /// </summary>
        /// <value>The total number of failed links.</value>
        [JsonPropertyName("total_failed")]
        public long TotalFailed { get; set; }

        /// <summary>
        /// The total number of stopped links.
        /// </summary>
        /// <value>The total number of stopped links.</value>
        [JsonPropertyName("total_stopped")]
        public long TotalStopped { get; set; }

        /// <summary>
        /// The total number of sending links.
        /// </summary>
        /// <value>The total number of sending links.</value>
        [JsonPropertyName("total_sending")]
        public long TotalSending { get; set; }
    }
}
