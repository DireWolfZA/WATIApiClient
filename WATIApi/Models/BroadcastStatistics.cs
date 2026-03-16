using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents statistics related to a broadcast.
    /// </summary>
    [DataContract(Name = "BroadcastStatisticsDto")]
    public partial class BroadcastStatistics {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastStatistics" /> class.
        /// </summary>
        /// <param name="totalRecipients">The total number of recipients for the broadcast.</param>
        /// <param name="totalPending">The total number of messages pending to be processed.</param>
        /// <param name="totalQueued">The total number of messages queued for sending.</param>
        /// <param name="totalSending">The total number of messages currently being sent.</param>
        /// <param name="totalSent">The total number of messages sent.</param>
        /// <param name="totalDelivered">The total number of messages delivered.</param>
        /// <param name="totalRead">The total number of messages read by recipients.</param>
        /// <param name="totalReplied">The total number of replies received from recipients.</param>
        /// <param name="totalFailed">The total number of messages that failed to send.</param>
        /// <param name="totalStopped">The total number of messages that were stopped.</param>
        public BroadcastStatistics(int totalRecipients = default, int totalPending = default, int totalQueued = default, int totalSending = default, int totalSent = default, int totalDelivered = default, int totalRead = default, int totalReplied = default, int totalFailed = default, int totalStopped = default) {
            this.TotalRecipients = totalRecipients;
            this.TotalPending = totalPending;
            this.TotalQueued = totalQueued;
            this.TotalSending = totalSending;
            this.TotalSent = totalSent;
            this.TotalDelivered = totalDelivered;
            this.TotalRead = totalRead;
            this.TotalReplied = totalReplied;
            this.TotalFailed = totalFailed;
            this.TotalStopped = totalStopped;
        }

        /// <summary>
        /// The total number of recipients for the broadcast
        /// </summary>
        /// <value>The total number of recipients for the broadcast</value>
        [JsonPropertyName("total_recipients")]
        public int TotalRecipients { get; set; }

        /// <summary>
        /// The total number of messages pending to be processed
        /// </summary>
        /// <value>The total number of messages pending to be processed</value>
        [JsonPropertyName("total_pending")]
        public int TotalPending { get; set; }

        /// <summary>
        /// The total number of messages queued for sending
        /// </summary>
        /// <value>The total number of messages queued for sending</value>
        [JsonPropertyName("total_queued")]
        public int TotalQueued { get; set; }

        /// <summary>
        /// The total number of messages currently being sent
        /// </summary>
        /// <value>The total number of messages currently being sent</value>
        [JsonPropertyName("total_sending")]
        public int TotalSending { get; set; }

        /// <summary>
        /// The total number of messages sent
        /// </summary>
        /// <value>The total number of messages sent</value>
        [JsonPropertyName("total_sent")]
        public int TotalSent { get; set; }

        /// <summary>
        /// The total number of messages delivered
        /// </summary>
        /// <value>The total number of messages delivered</value>
        [JsonPropertyName("total_delivered")]
        public int TotalDelivered { get; set; }

        /// <summary>
        /// The total number of messages read by recipients
        /// </summary>
        /// <value>The total number of messages read by recipients</value>
        [JsonPropertyName("total_read")]
        public int TotalRead { get; set; }

        /// <summary>
        /// The total number of replies received from recipients
        /// </summary>
        /// <value>The total number of replies received from recipients</value>
        [JsonPropertyName("total_replied")]
        public int TotalReplied { get; set; }

        /// <summary>
        /// The total number of messages that failed to send
        /// </summary>
        /// <value>The total number of messages that failed to send</value>
        [JsonPropertyName("total_failed")]
        public int TotalFailed { get; set; }

        /// <summary>
        /// The total number of messages that were stopped
        /// </summary>
        /// <value>The total number of messages that were stopped</value>
        [JsonPropertyName("total_stopped")]
        public int TotalStopped { get; set; }
    }
}
