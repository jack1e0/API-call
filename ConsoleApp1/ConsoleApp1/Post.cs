using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Post
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }
    }
}
