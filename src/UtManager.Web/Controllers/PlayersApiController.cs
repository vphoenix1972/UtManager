using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using UtManager.Core.Entities;
using UtManager.Core.Persistence;
using UtManager.Core.Services;

namespace UtManager.Web.Controllers
{
    [Route("api/players")]
    public class PlayersApiController : UtManagerControllerBase
    {
        private readonly IPlayersService _playersService;

        public PlayersApiController(IPlayersService playersService)
        {
            if (playersService == null)
                throw new ArgumentNullException(nameof(playersService));

            _playersService = playersService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _playersService.GetAll();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(Player player)
        {
            var result = _playersService.CreatePlayer(player);

            return Ok(result);
        }
    }
}