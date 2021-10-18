using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpotifyAPI.Models.Spotify
{
    public class Followers
    {
        [JsonPropertyName("href")]
        public string Href { get; set; }
        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
