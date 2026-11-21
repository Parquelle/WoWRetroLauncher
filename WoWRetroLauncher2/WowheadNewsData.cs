using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WoWRetroLauncher2
{// using System.Xml.Serialization;
 // XmlSerializer serializer = new XmlSerializer(typeof(Rss));
 // using (StringReader reader = new StringReader(xml))
 // {
 //    var test = (Rss)serializer.Deserialize(reader);
 // }

    [XmlRoot(ElementName = "link")]
    public class Link
    {

        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }

        [XmlAttribute(AttributeName = "rel")]
        public string Rel { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "image")]
    public class Image
    {

        [XmlElement(ElementName = "url")]
        public string Url { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "link")]
        public string Link { get; set; }
    }

    [XmlRoot(ElementName = "guid")]
    public class Guid
    {

        [XmlAttribute(AttributeName = "isPermaLink")]
        public bool IsPermaLink { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "content")]
    public class Content
    {

        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }

        [XmlAttribute(AttributeName = "medium")]
        public string Medium { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "height")]
        public int Height { get; set; }

        [XmlAttribute(AttributeName = "width")]
        public int Width { get; set; }
    }

    [XmlRoot(ElementName = "item")]
    public class Item
    {

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "link")]
        public string Link { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "category")]
        public string Category { get; set; }

        [XmlElement(ElementName = "pubDate")]
        public string PubDate { get; set; }

        [XmlElement(ElementName = "guid")]
        public Guid Guid { get; set; }

        [XmlElement(ElementName = "content")]
        public Content Content { get; set; }

        [XmlElement(ElementName = "encoded")]
        public string Encoded { get; set; }
    }

    [XmlRoot(ElementName = "channel")]
    public class Channel
    {

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "link")]
        public List<string> Link { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "image")]
        public Image Image { get; set; }

        [XmlElement(ElementName = "language")]
        public string Language { get; set; }

        [XmlElement(ElementName = "ttl")]
        public int Ttl { get; set; }

        [XmlElement(ElementName = "lastBuildDate")]
        public string LastBuildDate { get; set; }

        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
    }

    [XmlRoot(ElementName = "rss")]
    public class WowheadNewsObject
    {

        [XmlElement(ElementName = "channel")]
        public Channel Channel { get; set; }

        [XmlAttribute(AttributeName = "content")]
        public string Content { get; set; }

        [XmlAttribute(AttributeName = "media")]
        public string Media { get; set; }

        [XmlAttribute(AttributeName = "atom")]
        public string Atom { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public double Version { get; set; }

        [XmlText]
        public string Text { get; set; }
    }


}
