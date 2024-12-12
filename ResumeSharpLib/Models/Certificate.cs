using Newtonsoft.Json;
using NodaTime;

namespace ResumeSharpLib
{
    public partial class Certificate
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("date")]
        public OffsetDateTime Date { get; set; }
        [JsonProperty("issuer")]
        public string Issuer { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}