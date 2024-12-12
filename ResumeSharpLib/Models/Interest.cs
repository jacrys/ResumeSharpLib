using Newtonsoft.Json;

namespace ResumeSharpLib
{
    public partial class Interest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; }
    }
}