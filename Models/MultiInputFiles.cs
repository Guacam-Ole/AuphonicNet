using Newtonsoft.Json;

namespace AuphonicApi.Models
{
    public class MultiInputFiles
    {
        [JsonProperty("input_channels")]
        public int? InputChannels { get; set; }

        public string Service { get; set; }

        [JsonProperty("input_samplerate")]
        public int? InputSamplerate { get; set; }

        [JsonProperty("input_file")]
        public string InputFile { get; set; }

        [JsonProperty("input_bitrate")]
        public float? InputBitrate { get; set; }

        [JsonProperty("input_filetype")]
        public string InputFiletype { get; set; }

        public string Type { get; set; }

        [JsonProperty("input_length")]
        public float? InputLength { get; set; }
    }
}