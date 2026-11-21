using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWRetroLauncher2
{
    public class Datum
    {
        public string name { get; set; }
        public string build_config { get; set; }
        public int build_id { get; set; }
        public string cdn_config { get; set; }
        public string region { get; set; }
        public string version_name { get; set; }
        public string product_config { get; set; }
    }

    public class Refs
    {
        public string seqn { get; set; }
    }

    public class Result
    {
        public int seqn { get; set; }
        public string tact { get; set; }
        public string type { get; set; }
        public DateTime created_at { get; set; }
        public bool encrypted { get; set; }
        public List<Datum> data { get; set; }
        public string name { get; set; }
        public Refs refs { get; set; }
    }

    public class GameVersionObject
    {
        public bool success { get; set; }
        public Result result { get; set; }
    }
}


