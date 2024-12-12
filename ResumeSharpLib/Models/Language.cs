using Newtonsoft.Json;

namespace ResumeSharpLib
{
    public partial class Language
    {
        [JsonProperty("language")]
        public string LanguageLanguage { get; set; }

        [JsonProperty("fluency")]
        public string Fluency { get; set; }
    }
}