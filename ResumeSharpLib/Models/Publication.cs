using Newtonsoft.Json;
using NodaTime;

namespace ResumeSharpLib
{
    public partial class Publication
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("releaseDate")]
        public OffsetDateTime ReleaseDate { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
}