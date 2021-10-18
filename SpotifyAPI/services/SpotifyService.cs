using SpotifyAPI.Models;
using SpotifyAPI.Models.Spotify;
using SpotifyAPI.services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace SpotifyAPI.services
{
    public class SpotifyService : ISpotifyService
    {
        private readonly HttpClient _httpClient;

        public SpotifyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Release>> GetAllNewReleases(string countryCode, int limit, string accessToken, int? offset = 0)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",accessToken);
            var response = await _httpClient.GetAsync($"v1/browse/new-releases?country={countryCode.ToUpper()}&offset={offset}&limit={limit}");
            response.EnsureSuccessStatusCode();
            using var responseStream = await response.Content.ReadAsStreamAsync();
            var deserealizeObject = await JsonSerializer.DeserializeAsync<SpotifyBaseObject>(responseStream);

            return deserealizeObject?.Albums?.AlbumBase.Select(a => new Release
            {
                Name = a.Name,
                Artist = string.Join(",", a.Artist.Select(x => x.Name)),
                Date = a.ReleaseDate,
                ImageUrl = a.Images.FirstOrDefault().URL,
                Link = a.ExternalUrl.Spotify,

            }
                ); ;
        }
    }
}
