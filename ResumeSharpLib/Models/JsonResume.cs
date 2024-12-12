// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//    
//    VERSION 0.0.0
//
//    var jsonResume = JsonResume.FromJson(jsonString);

namespace ResumeSharpLib
{
	using System.Collections.Generic;

	using Newtonsoft.Json;
	using NodaTime;
    using NodaTime.Serialization.JsonNet;

    /// <summary>
    /// The JsonResume object based on https://jsonresume.org/schema/
    /// </summary>
    public partial class JsonResume
	{
		[JsonProperty("basics")]
		public Basics Basics { get; set; }

		[JsonProperty("work")]
		public List<Work> Works { get; set; }

		[JsonProperty("volunteer")]
		public List<Volunteer> Volunteers { get; set; }

		[JsonProperty("education")]
		public List<Education> Educations { get; set; }

		[JsonProperty("awards")]
		public List<Award> Awards { get; set; }

        [JsonProperty("certificates")]
        public List<Certificate> Certificates { get; set; }

		[JsonProperty("publications")]
		public List<Publication> Publications { get; set; }

        [JsonProperty("skills")]
		public List<Skill> Skills { get; set; }

		[JsonProperty("languages")]
		public List<Language> Languages { get; set; }

		[JsonProperty("interests")]
		public List<Interest> Interests { get; set; }

		[JsonProperty("references")]
        public List<Reference> References { get; set; }
		
        [JsonProperty("projects")]
		public List<Project> Projects { get; set; }
    }

    public partial class JsonResume
	{
		/// <summary>
		/// Create a JsonResume object from json string
		/// </summary>
		/// <param name="json">the json string</param>
		/// <returns></returns>
		public static JsonResume FromJson(string json) => JsonConvert.DeserializeObject<JsonResume>(json, Converter.Settings);
	}
}
