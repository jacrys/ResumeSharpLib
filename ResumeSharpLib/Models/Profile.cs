using Newtonsoft.Json;

namespace ResumeSharpLib
{
    public partial class Profile
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}