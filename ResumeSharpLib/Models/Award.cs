
using Newtonsoft.Json;
using NodaTime;

namespace ResumeSharpLib
{
    public partial class Award
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("date")]
        public OffsetDateTime Date { get; set; }

        [JsonProperty("awarder")]
        public string Awarder { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
}