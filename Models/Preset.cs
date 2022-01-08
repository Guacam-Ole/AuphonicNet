using Newtonsoft.Json;
using System;

namespace AuphonicApi.Models
{
    public class Preset
    {
        [JsonProperty("output_files")]
        public OutputFiles[] OutputFiles { get; set; }

        [JsonProperty("output_basename")]
        public string OutputBasename { get; set; }

        [JsonProperty("outgoing_services")]
        public OutgoingServices[] OutgoingServices { get; set; }

        public string Uuid { get; set; }
        public Algorithms Algorithms { get; set; }
        public string Image { get; set; }

        [JsonProperty("creation_time")]
        public DateTime CreationTime { get; set; }

        public string Thumbnail { get; set; }

        [JsonProperty("preset_name")]
        public string PresetName { get; set; }

        public Metadata Metadata { get; set; }

        [JsonProperty("multi_input_files")]
        public MultiInputFiles[] MultiInputFiles { get; set; }

        [JsonProperty("speech_recognition")]
        public SpeechRecognition SpeechRecognition { get; set; }

        [JsonProperty("is_multitrack")]
        public bool IsMultitrack { get; set; }

        public string Webhook { get; set; }
    }
}