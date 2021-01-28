using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfScores.Services.Players.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly ILogger<PlayersController> _logger;

        public PlayersController(ILogger<PlayersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return new List<Player>
            {
                new Player { Id = 1, Firstname = "Steven", Lastname = "Richardson", Handicap = 4.1 },
                new Player { Id = 2, Firstname = "Tiger", Lastname = "Woods", Handicap = 0 },
                new Player { Id = 1, Firstname = "Rory", Lastname = "Mcilroy", Handicap = 0 }
            };
        }
    }
}
