using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpotifyAPI.Models
{
    public class SpotifyImage
    {
        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("witdh")]
        public int Witdh { get; set; }
        [JsonPropertyName("url")]
        public string URL { get; set; }
    }
}
