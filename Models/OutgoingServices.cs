using Newtonsoft.Json;

namespace AuphonicApi.Models
{
    public class OutgoingServices
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        public string Type { get; set; }
        public string Uuid { get; set; }
        public string Email { get; set; }

        [JsonProperty("transfer_success")]
        public bool TransferSuccess { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        public bool Incoming { get; set; }
        public bool Outgoing { get; set; }

        [JsonProperty("result_page")]
        public object ResultPage { get; set; }

        [JsonProperty("result_urls")]
        public object[] ResultUrls { get; set; }

        public string Path { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }

        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }
    }
}