using Newtonsoft.Json;
using NodaTime;

namespace ResumeSharpLib
{
    public partial class Volunteer
    {
        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("startDate")]
        public OffsetDateTime StartDate { get; set; }

        [JsonProperty("endDate")]
        public OffsetDateTime EndDate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("highlights")]
        public List<string> Highlights { get; set; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }
    }
}