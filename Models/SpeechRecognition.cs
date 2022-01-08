namespace AuphonicApi.Models
{
    public class SpeechRecognition
    {
        public string[] Keywords { get; set; }
        public string Type { get; set; }
        public string Uuid { get; set; }
        public string Language { get; set; }
    }
}