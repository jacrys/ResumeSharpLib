using Newtonsoft.Json;

namespace ResumeSharpLib
{
    public partial class Reference
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reference")]
        public string ReferenceReference { get; set; }
    }
}