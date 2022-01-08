using Newtonsoft.Json;

namespace AuphonicApi.Models
{
    public class NoiseHumReduction
    {
        public object Denoise { get; set; }
        public bool Dehum { get; set; }
        public string Start { get; set; }
        [JsonProperty("start_sec")]
        public float? StartSec { get; set; }
        public string Stop { get; set; }
        [JsonProperty("stop_sec")]
        public float? StopSec { get; set; }
    }
}
