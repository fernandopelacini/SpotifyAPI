using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpotifyAPI.Models.Spotify
{
    public class SpotifyBaseObject
    {
        [JsonPropertyName("albums")]
        public Albums Albums { get; set; }
    }
}
