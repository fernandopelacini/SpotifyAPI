using SpotifyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SpotifyAPI.services
{
    public class SpotifyAccount : ISpotifyAccount
    {
        private readonly HttpClient _httpClient;

        public SpotifyAccount(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<string> GetToken(string clientId, string clientSecret)
        {
            //Token as it's the last part of the URi according the Spotify documentation
            //https://developer.spotify.com/documentation/general/guides/authorization-guide/
            //POST https://accounts.spotify.com/api/token
            var request = new HttpRequestMessage(HttpMethod.Post, "token");

            request.Headers.Authorization = new AuthenticationHeaderValue(
                "Basic",
                Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}")));

            request.Content = new FormUrlEncodedContent(new Dictionary<string, string> {
                {"grant_type","client_credentials" }            });

            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();
            using var responseStream = await response.Content.ReadAsStreamAsync();
            var deserealizeResult = await JsonSerializer.DeserializeAsync<SpotifyAuthorizationToken>(responseStream);
            return deserealizeResult.AccessToken;
        }
    }
}
