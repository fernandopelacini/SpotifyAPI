using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyAPI.services
{
   public interface ISpotifyAccount
    {
        Task<string> GetToken(string clientId, string clientSecret);
    }
}
