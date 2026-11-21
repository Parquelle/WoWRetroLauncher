using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWRetroLauncher2
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Post
    {
        public string excerpt { get; set; }
        public bool truncated { get; set; }
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public int topic_id { get; set; }
        public string topic_title { get; set; }
        public string topic_slug { get; set; }
        public string topic_html_title { get; set; }
        public string url { get; set; }
        public int category_id { get; set; }
        public int post_number { get; set; }
        public int posts_count { get; set; }
        public int post_type { get; set; }
        public int user_id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string avatar_template { get; set; }
        public string user_title { get; set; }
        public string primary_group_name { get; set; }
        public User user { get; set; }
        public Topic topic { get; set; }
    }

    public class BlizzardTrackerObject
    {
        public List<Post> posts { get; set; }
    }

    public class Topic
    {
        public string fancy_title { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string slug { get; set; }
        public int posts_count { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string avatar_template { get; set; }
        public string title { get; set; }
        public string primary_group_name { get; set; }
        public string animated_avatar { get; set; }
        public int post_count { get; set; }
    }


}
