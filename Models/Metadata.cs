using Newtonsoft.Json;

namespace AuphonicApi.Models
{
    public class Metadata
    {
        public string Album { get; set; }
        public string Subtitle { get; set; }
        public string License { get; set; }
        public string Summary { get; set; }
        public string Artist { get; set; }
        public string Track { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Url { get; set; }

        [JsonProperty("license_url")]
        public string LicenseUrl { get; set; }

        public string Year { get; set; }
        public string Genre { get; set; }

        [JsonProperty("append_chapters")]
        public bool AppendChapters { get; set; }

        public string[] Tags { get; set; }
        public Location Location { get; set; }
    }
}