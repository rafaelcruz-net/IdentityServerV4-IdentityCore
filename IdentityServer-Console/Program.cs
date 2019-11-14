using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace IdentityServer_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var tokenResponse = client.PostAsync("https://localhost:44387/connect/token",
                new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
                {
                            new KeyValuePair<string, string>("grant_type", "client_credentials"),
                            new KeyValuePair<string, string>("scope", "API"),
                            new KeyValuePair<string, string>("client_id", "79E0C2E2-D750-45BC-8FA3-1A9D5F9F82B5"),
                            new KeyValuePair<string, string>("client_secret", "1234567890"),
                })).Result;

            Console.WriteLine(tokenResponse);
        }
    }
}
