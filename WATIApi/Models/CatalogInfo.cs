using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents catalog information for a message template.
    /// </summary>
    [DataContract(Name = "CatalogInfoDto")]
    public partial class CatalogInfo {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogInfo" /> class.
        /// </summary>
        /// <param name="catalogID">The catalog identifier..</param>
        /// <param name="thumbnailProduct">Represents a catalog product.</param>
        /// <param name="isActive">Whether the catalog is active..</param>
        public CatalogInfo(string? catalogID = null, CatalogProduct? thumbnailProduct = null, bool isActive = default) {
            this.CatalogID = catalogID;
            this.ThumbnailProduct = thumbnailProduct ?? throw new ArgumentNullException(nameof(thumbnailProduct));
            this.IsActive = isActive;
        }

        /// <summary>
        /// The catalog identifier.
        /// </summary>
        [JsonPropertyName("catalog_id")]
        public string? CatalogID { get; set; }

        /// <summary>
        /// Represents a catalog product.
        /// </summary>
        [JsonPropertyName("thumbnail_product")]
        public CatalogProduct ThumbnailProduct { get; set; }

        /// <summary>
        /// Whether the catalog is active.
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }
    }
}
