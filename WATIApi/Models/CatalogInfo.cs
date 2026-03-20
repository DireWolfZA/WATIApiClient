using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents catalog information for a message template.
    /// </summary>
    [DataContract(Name = "CatalogInfoDto")]
    public class CatalogInfo {
        /// <summary>
        /// The catalog identifier.
        /// </summary>
        [JsonPropertyName("catalog_id")]
        public string? CatalogID { get; set; }
        /// <summary>
        /// Represents a catalog product.
        /// </summary>
        [JsonPropertyName("thumbnail_product")]
        public required CatalogProduct ThumbnailProduct { get; set; }
        /// <summary>
        /// Whether the catalog is active.
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }
    }
}
