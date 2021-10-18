using SpotifyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyAPI.services.Interfaces
{
public interface ISpotifyService
    {
        //https://developer.spotify.com/documentation/web-api/reference/#endpoint-get-new-releases
        Task<IEnumerable<Release>> GetAllNewReleases(string countryCode, int limit, string accessToken, int? offset);
    }
}
