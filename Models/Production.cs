using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuphonicApi.Models
{
    public class Production
    {
        public int Status { get; set; }
        [JsonProperty("status_string")]
        public string StatusString { get; set; }
        public Chapter[] Chapters { get; set; }
        [JsonProperty("outgoing_services")]
        public OutgoingServices[] OutgoingServices { get; set; }
        public string Uuid { get; set; }
        [JsonProperty("output_basename")]
        public string OutputBasename { get; set; }
        [JsonProperty("output_files")]
        public OutputFiles[] OutputFiles { get; set; }
        public string Image { get; set; }
        public string Thumbnail { get; set; }
        [JsonProperty("waveform_image")]
        public string WaveformImage { get; set; }
        [JsonProperty("creation_time")]
        public DateTime? CreationTime { get; set; }
        [JsonProperty("change_time")]
        public DateTime? ChangeTime { get; set; }
        public Algorithms Algorithms { get; set; }
        public string Service { get; set; }
        [JsonProperty("input_file")]
        public string InputFile { get; set; }
        public float? Length { get; set; }
        [JsonProperty("length_timestring")]
        public string LengthTimestring { get; set; }
        public int? Channels { get; set; }
        public int? Samplerate { get; set; }
        public float? Bitrate { get; set; }
        public string Format { get; set; }
        [JsonProperty("has_video")]
        public bool HasVideo { get; set; }
        [JsonProperty("cut_start")]
        public float? CutStart { get; set; }
        [JsonProperty("cut_end")]
        public float? CutEnd { get; set; }
        public Metadata Metadata { get; set; }
        [JsonProperty("multi_input_files")]
        public MultiInputFiles[] MultiInputFiles { get; set; }
        [JsonProperty("start_allowed")]
        public bool StartAllowed { get; set; }
        [JsonProperty("change_allowed")]
        public bool ChangeAllowed { get; set; }
        [JsonProperty("status_page")]
        public string StatusPage { get; set; }
        [JsonProperty("edit_page")]
        public string EditPage { get; set; }
        [JsonProperty("error_status")]
        public object ErrorStatus { get; set; }
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
        [JsonProperty("warning_status")]
        public object WarningStatus { get; set; }
        [JsonProperty("warning_message")]
        public string WarningMessage { get; set; }
        public string Webhook { get; set; }
        [JsonProperty("is_multitrack")]
        public bool IsMultitrack { get; set; }
        [JsonProperty("used_credits")]
        public UsedCredits UsedCredits { get; set; }
        [JsonProperty("speech_recognition")]
        public SpeechRecognition SpeechRecognition { get; set; }
        public Statistics Statistics { get; set; }
    }
}
