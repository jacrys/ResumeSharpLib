using System.Collections.Generic;
using Newtonsoft.Json;
using NodaTime;

namespace ResumeSharpLib
{
    public partial class Project
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("highlights")]
        public List<string> Highlights { get; set; }
        [JsonProperty("startDate")]
        public OffsetDateTime StartDate { get; set; }
        [JsonProperty("endDate")]
        public OffsetDateTime EndDate { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}