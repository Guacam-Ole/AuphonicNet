using Newtonsoft.Json;

namespace AuphonicApi.Models
{
    public class OutputFiles
    {
        public string Format { get; set; }
        public string Ending { get; set; }
        public string Suffix { get; set; }
        public string Filename { get; set; }

        [JsonProperty("split_on_chapters")]
        public bool SplitOnChapters { get; set; }

        public int Bitrate { get; set; }

        [JsonProperty("mono_mixdown")]
        public bool MonoMixdown { get; set; }

        [JsonProperty("size_string")]
        public string SizeString { get; set; }

        [JsonProperty("outgoing_services")]
        public object[] OutgoingServices { get; set; }

        [JsonProperty("outgoing_service_urls")]
        public object[] OutgoingServiceUrls { get; set; }
    }
}