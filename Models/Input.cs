using Newtonsoft.Json;

namespace AuphonicApi.Models
{
    public class Input
    {
        public object[] Lra { get; set; }
        [JsonProperty("noise_level")]
        public object[] NoiseLevel { get; set; }
        [JsonProperty("max_momentary")]
        public object[] MaxMomentary { get; set; }
        [JsonProperty("signal_level")]
        public object[] SignalLevel { get; set; }
        public object[] Snr { get; set; }
        [JsonProperty("max_shortterm")]
        public object[] MaxShortterm { get; set; }
        public object[] Loudness { get; set; }
    }
}
