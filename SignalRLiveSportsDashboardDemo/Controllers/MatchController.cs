using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SignalRLiveSportsDashboardDemo.Data;
using SignalRLiveSportsDashboardDemo.Hubs;
using SignalRLiveSportsDashboardDemo.Models;
using SignalRLiveSportsDashboardDemo.Services;

namespace SignalRLiveSportsDashboardDemo.Controllers
{
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IFootballService _footballService;
        private readonly IHubContext<MatchCenterHub> _hub;

        public MatchController(IFootballService footballService, IHubContext<MatchCenterHub> hub)
        {
            _footballService = footballService;
            _hub = hub;
        }

        // GET: api/Matches
        [HttpGet]
        [Route("api/Matches")]
        public async Task<IEnumerable<MatchViewModel>> GetMatchesAsync()
        {
            return await _footballService.GetMatchesAsync();
        }

        // POST: api/Matches
        [HttpPut]
        [Route("api/Matches")]
        public async Task UpdateMatchAsync(MatchUpdateModel model)
        {
            await _footballService.UpdateMatchAsync(model);

            await _hub.Clients.All.SendAsync("RefreshMatchCenter");
        }
    }
}
