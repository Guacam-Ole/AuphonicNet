using Newtonsoft.Json;

namespace AuphonicApi.Models
{
    public class Chapter
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public string Start { get; set; }
        [JsonProperty("start_sec")]
        public float? startSec { get; set; }
        [JsonProperty("start_output")]
        public string startOutput { get; set; }
        [JsonProperty("start_output_sec")]
        public float? StartOutputSec { get; set; }
    }
}
