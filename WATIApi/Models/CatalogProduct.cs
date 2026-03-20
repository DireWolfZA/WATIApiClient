using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a catalog product.
    /// </summary>
    [DataContract(Name = "CatalogProductDto")]
    public class CatalogProduct {
        /// <summary>
        /// The product retailer identifier.
        /// </summary>
        [JsonPropertyName("product_retailer_id")]
        public string? ProductRetailerID { get; set; }
        /// <summary>
        /// The product identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// The retailer product group identifier.
        /// </summary>
        [JsonPropertyName("retailer_product_group_id")]
        public string? RetailerProductGroupID { get; set; }
        /// <summary>
        /// The product price.
        /// </summary>
        [JsonPropertyName("price")]
        public string? Price { get; set; }
        /// <summary>
        /// The sale price.
        /// </summary>
        [JsonPropertyName("sale_price")]
        public string? SalePrice { get; set; }
        /// <summary>
        /// The product name.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// The currency.
        /// </summary>
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
        /// <summary>
        /// The image URL.
        /// </summary>
        [JsonPropertyName("image_url")]
        public string? ImageURL { get; set; }
        /// <summary>
        /// The list of product errors.
        /// </summary>
        [JsonPropertyName("errors")]
        public List<ProductError>? Errors { get; set; }
    }
}
