using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalRLiveSportsDashboardDemo.Models;

namespace SignalRLiveSportsDashboardDemo.Services
{
    public interface IFootballService
    {
        Task<IEnumerable<MatchViewModel>> GetMatchesAsync();
        Task UpdateMatchAsync(MatchUpdateModel model);
    }
}
