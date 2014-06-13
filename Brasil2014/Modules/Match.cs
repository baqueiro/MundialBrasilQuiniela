using Brasil2014.Data;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brasil2014.Modules
{
    public class Match : NancyModule
    {
        public Match(ITeamRepository teamRepository, IMatchRepository matchRepository)
            : base("/api")
        {
            Get["/Matches"] = _ =>
                {
                    var teams = teamRepository.GetTeams();
                    var matches = matchRepository.GetMathes(teams);

                    return matches;

                };
        }
    }
}