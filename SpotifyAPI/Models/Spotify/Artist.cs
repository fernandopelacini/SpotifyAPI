using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpotifyAPI.Models.Spotify
{
    public class Artist
    {
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrl { get; set; }
        [JsonPropertyName("followers")]
        public Followers Followers { get; set; }
        [JsonPropertyName("genres")]
        public string[] Genres { get; set; }
        [JsonPropertyName("href")]
        public string Href { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("images")]
        public SpotifyImage[] Images { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("popularity")]
        public int Popularity { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
