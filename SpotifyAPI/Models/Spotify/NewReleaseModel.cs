using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpotifyAPI.Models
{
    public class NewReleaseModel
    {
        [JsonPropertyName("external_urls")]
    public ExternalUrl ExternalUrl { get; set; }
        [JsonPropertyName("href")]
        public string HRef { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }


}
