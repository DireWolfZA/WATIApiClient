using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a catalog product.
    /// </summary>
    [DataContract(Name = "CatalogProductDto")]
    public partial class CatalogProduct {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogProduct" /> class.
        /// </summary>
        /// <param name="productRetailerID">The product retailer identifier..</param>
        /// <param name="id">The product identifier..</param>
        /// <param name="retailerProductGroupID">The retailer product group identifier..</param>
        /// <param name="price">The product price..</param>
        /// <param name="salePrice">The sale price..</param>
        /// <param name="name">The product name..</param>
        /// <param name="currency">The currency..</param>
        /// <param name="imageURL">The image URL..</param>
        /// <param name="errors">The list of product errors..</param>
        public CatalogProduct(string? productRetailerID = null, string? id = null, string? retailerProductGroupID = null, string? price = null, string? salePrice = null, string? name = null, string? currency = null, string? imageURL = null, List<ProductError>? errors = null) {
            this.ProductRetailerID = productRetailerID;
            this.ID = id;
            this.RetailerProductGroupID = retailerProductGroupID;
            this.Price = price;
            this.SalePrice = salePrice;
            this.Name = name;
            this.Currency = currency;
            this.ImageURL = imageURL;
            this.Errors = errors;
        }

        /// <summary>
        /// The product retailer identifier.
        /// </summary>
        /// <value>The product retailer identifier.</value>
        [JsonPropertyName("product_retailer_id")]
        public string? ProductRetailerID { get; set; }

        /// <summary>
        /// The product identifier.
        /// </summary>
        /// <value>The product identifier.</value>
        [JsonPropertyName("id")]
        public string? ID { get; set; }

        /// <summary>
        /// The retailer product group identifier.
        /// </summary>
        /// <value>The retailer product group identifier.</value>
        [JsonPropertyName("retailer_product_group_id")]
        public string? RetailerProductGroupID { get; set; }

        /// <summary>
        /// The product price.
        /// </summary>
        /// <value>The product price.</value>
        [JsonPropertyName("price")]
        public string? Price { get; set; }

        /// <summary>
        /// The sale price.
        /// </summary>
        /// <value>The sale price.</value>
        [JsonPropertyName("sale_price")]
        public string? SalePrice { get; set; }

        /// <summary>
        /// The product name.
        /// </summary>
        /// <value>The product name.</value>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The currency.
        /// </summary>
        /// <value>The currency.</value>
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// The image URL.
        /// </summary>
        /// <value>The image URL.</value>
        [JsonPropertyName("image_url")]
        public string? ImageURL { get; set; }

        /// <summary>
        /// The list of product errors.
        /// </summary>
        /// <value>The list of product errors.</value>
        [JsonPropertyName("errors")]
        public List<ProductError>? Errors { get; set; }
    }
}
