using Newtonsoft.Json;
using NodaTime;

namespace ResumeSharpLib
{
    public partial class Education
    {
        [JsonProperty("institution")]
        public string Institution { get; set; }

        [JsonProperty("area")]
        public string Area { get; set; }

        [JsonProperty("studyType")]
        public string StudyType { get; set; }

        [JsonProperty("startDate")]
        public OffsetDateTime StartDate { get; set; }

        [JsonProperty("endDate")]
        public OffsetDateTime EndDate { get; set; }

        [JsonProperty("gpa")]
        public string Gpa { get; set; }

        [JsonProperty("courses")]
        public List<string> Courses { get; set; }
    }
}