using System;
using System.Net.Http;
using System.Text;

namespace AuphonicApi
{
    public class Authentication
    {
        private readonly string _username;
        private readonly string _password;

        public Authentication(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void AddBasicAuthToRequest(HttpRequestMessage request)
        {
            var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_username}:{_password}"));
            request.Headers.Add("Authorization", $"Basic {base64authorization}");
        }
    }
}