using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NodaTime;
using NodaTime.Serialization.JsonNet;

namespace ResumeSharpLib
{

    /// <summary>
    /// The JsonJob object based on https://jsonresume.org/job-description-schema/
    /// </summary>
    public partial class JsonJob
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public OffsetDateTime Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("remote")]
        public string Remote { get; set; }

        [JsonProperty("salary")]
        public string Salary { get; set; }

        [JsonProperty("experience")]
        public string Experience { get; set; }

        [JsonProperty("responsibilities")]
        public List<string> Responsibilities { get; set; }

        [JsonProperty("qualification")]
        public List<string> Qualifications { get; set; }

        [JsonProperty("skills")]
        public List<Skill> Skills { get; set; }

    }


    public partial class JsonJob
    {
        /// <summary>
        /// Create a JsonResume object from json string
        /// </summary>
        /// <param name="json">the json string</param>
        /// <returns></returns>
        public static JsonJob FromJson(string json) => JsonConvert.DeserializeObject<JsonJob>(json, Converter.Settings);
    }
}
