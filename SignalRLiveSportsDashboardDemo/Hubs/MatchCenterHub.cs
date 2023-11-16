using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SignalRLiveSportsDashboardDemo.Models;
using SignalRLiveSportsDashboardDemo.Services;

namespace SignalRLiveSportsDashboardDemo.Hubs
{
    public class MatchCenterHub : Hub
    {
        public async Task SendMatchCenterUpdate()
        {
            await Clients.All.SendAsync("RefreshMatchCenter");
        }
    }
}
