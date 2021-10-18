using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpotifyAPI.Models.Spotify
{
    public class AlbumBase
    {
        [JsonPropertyName("album_type")]
        public string  AlbumType { get; set; }

        [JsonPropertyName("artists")]
        public Artist[] Artist { get; set; }
        [JsonPropertyName("available_markets")]
        public object[] AvailableMarkets { get; set; }
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrl { get; set; }
        [JsonPropertyName("href")]
        public string  Href { get; set; }
        [JsonPropertyName("id")]
        public string Id{ get; set; }
        [JsonPropertyName("images")]
        public SpotifyImage[] Images { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }
        [JsonPropertyName("release_date_precision")]
        public string ReleaseDatePrecision { get; set; }
        [JsonPropertyName("total_tracks")]
        public int TotalTracks { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }

}
