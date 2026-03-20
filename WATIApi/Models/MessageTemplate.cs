using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WATIApi.Models {
    /// <summary>
    /// Represents a message template with its configuration and parameters.
    /// </summary>
    [DataContract(Name = "MessageTemplateDto")]
    public class MessageTemplate {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageTemplate" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the message template.</param>
        /// <param name="name">The name of the message template.</param>
        /// <param name="category">The category of the template.</param>
        /// <param name="subCategory">The subcategory of the template.</param>
        /// <param name="catalogInfo">catalogInfo.</param>
        /// <param name="hsm">The HSM (Highly Structured Message) content.</param>
        /// <param name="hsmOriginal">The original HSM content.</param>
        /// <param name="customParams">The list of custom parameters associated with this template.</param>
        /// <param name="status">The current status of the template.</param>
        /// <param name="languageOption">languageOption.</param>
        /// <param name="lastModified">The last modification date of the template.</param>
        /// <param name="type">The type of the message template.</param>
        /// <param name="header">header.</param>
        /// <param name="body">The body content of the template.</param>
        /// <param name="bodyOriginal">The original body content of the template.</param>
        /// <param name="footer">The footer content of the template.</param>
        /// <param name="buttons">The list of button components.</param>
        /// <param name="buttonsType">The type of buttons used in the template.</param>
        /// <param name="carouselCards">The list of carousel cards for the template.</param>
        /// <param name="expiresIn">Expiration time in seconds.</param>
        /// <param name="includeExpiryTime">Whether to include expiry time.</param>
        /// <param name="addSecurityRecommendation">Whether to add security recommendation.</param>
        /// <param name="isUrlBtnClickTrackingEnabled">Whether URL button click tracking is enabled.</param>
        /// <param name="limitedTimeOffer">limitedTimeOffer.</param>
        /// <param name="quality">The quality rating of the template.</param>
        /// <param name="creationMethod">The method used to create the template.</param>
        public MessageTemplate(string? id = null, string? name = null, string? category = null, string? subCategory = null, CatalogInfo? catalogInfo = null, string? hsm = null, string? hsmOriginal = null, List<TemplateParameter>? customParams = null, string? status = null, LanguageOption? languageOption = null, DateTime lastModified = default, string? type = null, HeaderMessageTemplateComponent? header = default, string? body = null, string? bodyOriginal = null, string? footer = null, List<ButtonMessageTemplateComponent>? buttons = null, string? buttonsType = null, List<CarouselMessageTemplateViewModel>? carouselCards = null, int expiresIn = default, bool includeExpiryTime = default, bool addSecurityRecommendation = default, bool isUrlBtnClickTrackingEnabled = default, LimitedTimeOffer? limitedTimeOffer = null, string? quality = null, string? creationMethod = null) {
            this.ID = id;
            this.Name = name;
            this.Category = category;
            this.SubCategory = subCategory;
            this.CatalogInfo = catalogInfo;
            this.HSM = hsm;
            this.HSMOriginal = hsmOriginal;
            this.CustomParams = customParams;
            this.Status = status;
            this.LanguageOption = languageOption ?? throw new ArgumentNullException(nameof(LanguageOption));
            this.LastModified = lastModified;
            this.Type = type;
            this.Header = header;
            this.Body = body;
            this.BodyOriginal = bodyOriginal;
            this.Footer = footer;
            this.Buttons = buttons;
            this.ButtonsType = buttonsType;
            this.CarouselCards = carouselCards;
            this.ExpiresIn = expiresIn;
            this.IncludeExpiryTime = includeExpiryTime;
            this.AddSecurityRecommendation = addSecurityRecommendation;
            this.IsURLBtnClickTrackingEnabled = isUrlBtnClickTrackingEnabled;
            this.LimitedTimeOffer = limitedTimeOffer;
            this.Quality = quality;
            this.CreationMethod = creationMethod;
        }

        /// <summary>
        /// The unique identifier of the message template.
        /// </summary>
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        /// <summary>
        /// The name of the message template.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// The category of the template.
        /// </summary>
        [JsonPropertyName("category")]
        public string? Category { get; set; }
        /// <summary>
        /// The subcategory of the template.
        /// </summary>
        [JsonPropertyName("sub_category")]
        public string? SubCategory { get; set; }
        /// <summary>
        /// Gets or Sets CatalogInfo
        /// </summary>
        [JsonPropertyName("catalog_info")]
        public CatalogInfo? CatalogInfo { get; set; }
        /// <summary>
        /// The HSM (Highly Structured Message) content.
        /// </summary>
        [JsonPropertyName("hsm")]
        public string? HSM { get; set; }
        /// <summary>
        /// The original HSM content.
        /// </summary>
        [JsonPropertyName("hsm_original")]
        public string? HSMOriginal { get; set; }
        /// <summary>
        /// The list of custom parameters associated with this template.
        /// </summary>
        [JsonPropertyName("custom_params")]
        public List<TemplateParameter>? CustomParams { get; set; }
        /// <summary>
        /// The current status of the template.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        /// <summary>
        /// Gets or Sets LanguageOption
        /// </summary>
        [JsonPropertyName("language_option")]
        public LanguageOption LanguageOption { get; set; }
        /// <summary>
        /// The last modification date of the template.
        /// </summary>
        [JsonPropertyName("last_modified")]
        public DateTime LastModified { get; set; }
        /// <summary>
        /// The type of the message template.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [JsonPropertyName("header")]
        public HeaderMessageTemplateComponent? Header { get; set; }
        /// <summary>
        /// The body content of the template.
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get; set; }
        /// <summary>
        /// The original body content of the template.
        /// </summary>
        [JsonPropertyName("body_original")]
        public string? BodyOriginal { get; set; }
        /// <summary>
        /// The footer content of the template.
        /// </summary>
        [JsonPropertyName("footer")]
        public string? Footer { get; set; }
        /// <summary>
        /// The list of button components.
        /// </summary>
        [JsonPropertyName("buttons")]
        public List<ButtonMessageTemplateComponent>? Buttons { get; set; }
        /// <summary>
        /// The type of buttons used in the template.
        /// </summary>
        [JsonPropertyName("buttons_type")]
        public string? ButtonsType { get; set; }
        /// <summary>
        /// The list of carousel cards for the template.
        /// </summary>
        [JsonPropertyName("carousel_cards")]
        public List<CarouselMessageTemplateViewModel>? CarouselCards { get; set; }
        /// <summary>
        /// Expiration time in seconds.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
        /// <summary>
        /// Whether to include expiry time.
        /// </summary>
        [JsonPropertyName("include_expiry_time")]
        public bool IncludeExpiryTime { get; set; }
        /// <summary>
        /// Whether to add security recommendation.
        /// </summary>
        [JsonPropertyName("add_security_recommendation")]
        public bool AddSecurityRecommendation { get; set; }
        /// <summary>
        /// Whether URL button click tracking is enabled.
        /// </summary>
        [JsonPropertyName("is_url_btn_click_tracking_enabled")]
        public bool IsURLBtnClickTrackingEnabled { get; set; }
        /// <summary>
        /// Gets or Sets LimitedTimeOffer
        /// </summary>
        [JsonPropertyName("limited_time_offer")]
        public LimitedTimeOffer? LimitedTimeOffer { get; set; }
        /// <summary>
        /// The quality rating of the template.
        /// </summary>
        [JsonPropertyName("quality")]
        public string? Quality { get; set; }
        /// <summary>
        /// The method used to create the template.
        /// </summary>
        [JsonPropertyName("creation_method")]
        public string? CreationMethod { get; set; }
    }
}
