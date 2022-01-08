using Newtonsoft.Json;

namespace AuphonicApi.Models
{
    public class Statistics
    {
        public Levels Levels { get; set; }
        [JsonProperty("music_speech")]
        public MusicSpeech[] MusicSpeech { get; set; }
        [JsonProperty("noise_hum_reduction")]
        public NoiseHumReduction[] NoiseHumReduction { get; set; }
    }
}
