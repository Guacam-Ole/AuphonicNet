using Newtonsoft.Json;

namespace AuphonicApi.Models
{
    public class MusicSpeech
    {
        public string Label { get; set; }
        public string Start { get; set; }
        [JsonProperty("start_sec")]
        public float? StartSec { get; set; }
        public string Stop { get; set; }
        [JsonProperty("stop_sec")]
        public float? StopSec { get; set; }
    }
}
