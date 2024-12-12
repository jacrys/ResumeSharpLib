using System.Collections.Generic;
using Newtonsoft.Json;

namespace ResumeSharpLib
{
    public partial class Basics
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("profiles")]
        public List<Profile> Profiles { get; set; }
    }
}