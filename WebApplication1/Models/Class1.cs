using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Class1
    {
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Self
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
        public Related related { get; set; }
    }

    public class Meta
    {
        public Links links { get; set; }
        public string alt { get; set; }
        public string title { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Jsonapi
    {
        public string version { get; set; }
        public Meta meta { get; set; }
    }

    public class Path
    {
        public object alias { get; set; }
        public object pid { get; set; }
        public string langcode { get; set; }
    }

    public class Body
    {
        public string value { get; set; }
        public string format { get; set; }
        public string processed { get; set; }
        public string summary { get; set; }
    }

    public class Comment
    {
        public int status { get; set; }
        public int cid { get; set; }
        public int last_comment_timestamp { get; set; }
        public object last_comment_name { get; set; }
        public int last_comment_uid { get; set; }
        public int comment_count { get; set; }
    }

    public class Attributes
    {
        //public int drupal_internal__nid { get; set; }
        //public int drupal_internal__vid { get; set; }
        public string langcode { get; set; }
        //public DateTime revision_timestamp { get; set; }
        public object revision_log { get; set; }
        //public bool status { get; set; }
        public string title { get; set; }
        //public DateTime created { get; set; }
        //public DateTime changed { get; set; }
        //public bool promote { get; set; }
        //public bool sticky { get; set; }
        //public bool default_langcode { get; set; }
        //public bool revision_translation_affected { get; set; }
        public Path path { get; set; }
        public Body body { get; set; }
        public Comment comment { get; set; }
        public FieldImage fieldImage { get; set; }

    }

    public class Data
    {
        public string type { get; set; }
        public string id { get; set; }
        public Meta meta { get; set; }
        public Links links { get; set; }
        public Attributes attributes { get; set; }
        public Relationships relationships { get; set; }
    }

    public class Related
    {
        public string href { get; set; }
    }

    public class NodeType
    {
        public Data data { get; set; }
        public Links links { get; set; }
    }

    public class RevisionUid
    {
        public Data data { get; set; }
        public Links links { get; set; }
    }

    public class Uid
    {
        public Data data { get; set; }
        public Links links { get; set; }
    }

    public class FieldImage
    {
        public int target_id { get; set; }
    }

    public class FieldTags
    {
        public List<object> data { get; set; }
        public Links links { get; set; }
    }

    public class Relationships
    {
        public NodeType node_type { get; set; }
        public RevisionUid revision_uid { get; set; }
        public Uid uid { get; set; }
        public FieldImage field_image { get; set; }
        public FieldTags field_tags { get; set; }
    }

    public class Article
    {
        public Jsonapi jsonapi { get; set; }
        public Data data { get; set; }
        public Links links { get; set; }
    }


}
