using System.Collections.Generic;
using Newtonsoft.Json;

namespace ResumeSharpLib
{
    public partial class Skill
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; }
    }
}