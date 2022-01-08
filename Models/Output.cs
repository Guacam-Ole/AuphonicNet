using Newtonsoft.Json;

namespace AuphonicApi.Models
{
    public class Output
    {
        public object[] Lra { get; set; }
        [JsonProperty("max_shortterm")]
        public object[] MaxShortterm { get; set; }
        [JsonProperty("max_momentary")]
        public object[] MaxMomentary { get; set; }
        [JsonProperty("gain_min")]
        public object[] GainMin { get; set; }
        public object[] Peak { get; set; }
        [JsonProperty("gain_mean")]
        public object[] GainMean { get; set; }
        public object[] Loudness { get; set; }
        [JsonProperty("gain_max")]
        public object[] GainMax { get; set; }
    }
}
