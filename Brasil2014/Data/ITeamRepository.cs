using Brasil2014.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brasil2014.Data
{
    public interface ITeamRepository
    {
        List<TeamModel> GetTeams();
    }
}
