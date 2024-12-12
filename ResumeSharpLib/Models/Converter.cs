using Newtonsoft.Json;
using NodaTime.Serialization.JsonNet;

namespace ResumeSharpLib
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None
        }.ConfigureForNodaTime(NodaTime.DateTimeZoneProviders.Tzdb);
    }
}