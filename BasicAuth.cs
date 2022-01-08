using System;
using System.Net.Http;
using System.Text;

namespace AuphonicApi
{
    public static class BasicAuth
    {
        private static string _username;
        private static string _password;    
        public static void SetCredentials(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public static void AddBasicAuth(this HttpRequestMessage request)
        {
            if (_username == null || _password == null) return;
            var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_username}:{_password}"));
            request.Headers.Add("Authorization", $"Basic {base64authorization}");
        }
    }
}