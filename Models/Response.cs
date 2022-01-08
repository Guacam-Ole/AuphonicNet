using Newtonsoft.Json;

namespace AuphonicApi.Models
{
    public class Response<T>
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }

        [JsonProperty("form_errors")]
        public object FormErrors { get; set; }
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }
}