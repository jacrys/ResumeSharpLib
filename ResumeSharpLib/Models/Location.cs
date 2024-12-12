using Newtonsoft.Json;

namespace ResumeSharpLib
{
    public partial class Location
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }
    }
}