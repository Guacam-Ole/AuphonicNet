using System;
using System.Net.Http;
using System.Text;

namespace AuphonicApi
{
    public static class BasicAuth
    {
        public static void AddBasicAuth(this HttpRequestMessage request, string username, string password)
        {
            if (username == null || password == null) return;
            var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            request.Headers.Add("Authorization", $"Basic {base64authorization}");
        }
    }
}