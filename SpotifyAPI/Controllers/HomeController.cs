using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SpotifyAPI.Models;
using SpotifyAPI.services;
using SpotifyAPI.services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISpotifyAccount _spotifyAccount;
        private readonly IConfiguration _configuration;
        private readonly ISpotifyService _spotifyService;

        public HomeController(ILogger<HomeController> logger, ISpotifyAccount spotifyAccount,
                IConfiguration configuration, ISpotifyService spotifyService)
        {
            _logger = logger;
            _spotifyAccount = spotifyAccount;
            _configuration = configuration;
            _spotifyService = spotifyService;
        }

        public async Task<IActionResult> Index()
        {
            var data =await GetNewReleases();
            return View(data);
        }

        private async Task<IEnumerable<Release>> GetNewReleases()
        {
            try
            {
                var token = await _spotifyAccount.GetToken(_configuration["Spotify:client_id"], _configuration["Spotify:client_secret"]);
                var newReleases = await _spotifyService.GetAllNewReleases("AR", 10, token, 0);
                return newReleases;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);//Todo log error correclty
                return Enumerable.Empty<Release>();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
