using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpotifyAPI.Models
{
    public class ExternalUrl
    {
        [JsonPropertyName("spotify")]
        public string Spotify { get; set; }
    }
}
