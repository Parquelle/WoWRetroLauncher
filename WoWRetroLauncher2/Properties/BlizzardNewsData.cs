using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWRetroLauncher2
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Banner
    {
        public bool displayProductIcon { get; set; }
    }

    public class ContentItem
    {
        public string contentId { get; set; }
        public string contentType { get; set; }
        public Context context { get; set; }
        public NewsPostProperties properties { get; set; }
    }

    public class Context
    {
        public string locale { get; set; }
        public string cxpProductId { get; set; }
        public string layoutTemplateId { get; set; }
        public string region { get; set; }
        public bool includeFeed { get; set; }
        public bool includeShopRecommendations { get; set; }
        public string feedProductScope { get; set; }
        public List<string> cxpProductIds { get; set; }
        public string feedFreshness { get; set; }
        public string feedStrategy { get; set; }
        public List<string> feedContentTypes { get; set; }
    }

    public class CxpProduct
    {
        public string cxpProductId { get; set; }
        public int titleId { get; set; }
        public string title { get; set; }
        public string internalTitle { get; set; }
        public string productCode { get; set; }
        public string segment { get; set; }
        public Logo logo { get; set; }
        public Context context { get; set; }
        public string tactProductCode { get; set; }
        public string gamePackageId { get; set; }
    }

    public class Feed
    {
        public List<ContentItem> contentItems { get; set; }
        public Context context { get; set; }
        public Pagination pagination { get; set; }
    }

    public class Gradient
    {
        public string type { get; set; }
    }

    public class Logo
    {
        public string imageUrl { get; set; }
        public string imageFileType { get; set; }
        public string imageAltText { get; set; }
        public string url { get; set; }
        public string fileType { get; set; }
        public string altText { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Pagination
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int feedOffset { get; set; }
        public int feedLimit { get; set; }
        public bool hasNextPage { get; set; }
    }

    public class NewsPostProperties
    {
        public string title { get; set; }
        public string internalTitle { get; set; }
        public CxpProduct cxpProduct { get; set; }
        public string cxpProductId { get; set; }
        public string summary { get; set; }
        public List<object> cardActions { get; set; }
        public string category { get; set; }
        public StaticAsset staticAsset { get; set; }
        public DateTime lastUpdated { get; set; }
        public string author { get; set; }
        public string newsUrl { get; set; }
        public string newsSSOUrl { get; set; }
        public string newsPath { get; set; }
        public string newsId { get; set; }
        public string newsSlug { get; set; }
        public Banner banner { get; set; }
        public Gradient gradient { get; set; }
        public string callToAction { get; set; }
    }

    public class BlizzardNewsObject
    {
        public string layoutId { get; set; }
        public List<object> sections { get; set; }
        public Context context { get; set; }
        public Feed feed { get; set; }
    }

    public class StaticAsset
    {
        public string imageUrl { get; set; }
        public string imageFileType { get; set; }
        public string imageAltText { get; set; }
        public string url { get; set; }
        public string fileType { get; set; }
        public string altText { get; set; }
    }


}
