﻿using System.Web.Http;
using RSMuseum.Services;

namespace RSMuseum.MVC.Controllers.api.v2
{
    public class GuildsApiV2Controller : ApiController
    {
        private readonly GuildService _guildService;

        public GuildsApiV2Controller(GuildService guildService) {
            _guildService = guildService;
        }

        [HttpGet]
        [Route("api/v2/guilds")]
        public IHttpActionResult ListGuilds() {
            var allGuilds = _guildService.GetGuildsDTO();
            return Ok(allGuilds);
        }
    }
}