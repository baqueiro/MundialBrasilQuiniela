using Brasil2014.Data;
using Brasil2014.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brasil2014.Impl
{
    public class TeamRepository : ITeamRepository
    {
        public List<TeamModel> GetTeams()
        {
            List<TeamModel> teams = new List<TeamModel>(32);

            teams.Add(new TeamModel()
            {
                Id = 1,
                Name = "Brasil",
                UriImg = "http://img.fifa.com/images/flags/4/bra.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 2,
                Name = "Croacia",
                UriImg = "http://img.fifa.com/images/flags/4/cro.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 3,
                Name = "México",
                UriImg = "http://img.fifa.com/images/flags/4/mex.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 4,
                Name = "Camerún",
                UriImg = "http://img.fifa.com/images/flags/4/cmr.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 5,
                Name = "España",
                UriImg = "http://img.fifa.com/images/flags/4/esp.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 6,
                Name = "Holanda",
                UriImg = "http://img.fifa.com/images/flags/4/ned.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 7,
                Name = "Chile",
                UriImg = "http://img.fifa.com/images/flags/4/chi.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 8,
                Name = "Australia",
                UriImg = "http://img.fifa.com/images/flags/4/aus.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 9,
                Name = "Colombia",
                UriImg = "http://img.fifa.com/images/flags/4/col.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 10,
                Name = "Grecia",
                UriImg = "http://img.fifa.com/images/flags/4/gre.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 11,
                Name = "Uruguay",
                UriImg = "http://img.fifa.com/images/flags/4/uru.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 12,
                Name = "Costa rica",
                UriImg = "http://img.fifa.com/images/flags/4/crc.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 13,
                Name = "Inglaterra",
                UriImg = "http://img.fifa.com/images/flags/4/eng.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 14,
                Name = "Italia",
                UriImg = "http://img.fifa.com/images/flags/4/ita.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 15,
                Name = "Costa de Marfil",
                UriImg = "http://img.fifa.com/images/flags/4/civ.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 16,
                Name = "Japón",
                UriImg = "http://img.fifa.com/images/flags/4/jpn.png"
            });


            teams.Add(new TeamModel()
            {
                Id = 17,
                Name = "Suiza",
                UriImg = "http://img.fifa.com/images/flags/4/sui.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 18,
                Name = "Ecuador",
                UriImg = "http://img.fifa.com/images/flags/4/ecu.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 19,
                Name = "Francia",
                UriImg = "http://img.fifa.com/images/flags/4/fra.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 20,
                Name = "Honduras",
                UriImg = "http://img.fifa.com/images/flags/4/hon.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 21,
                Name = "Argentina",
                UriImg = "http://img.fifa.com/images/flags/4/arg.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 22,
                Name = "Bosnia y Herzegovina",
                UriImg = "http://img.fifa.com/images/flags/4/bih.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 23,
                Name = "Alemania",
                UriImg = "http://img.fifa.com/images/flags/4/ger.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 24,
                Name = "Portugal",
                UriImg = "http://img.fifa.com/images/flags/4/por.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 25,
                Name = "Irán",
                UriImg = "http://img.fifa.com/images/flags/4/irn.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 26,
                Name = "Nigeria",
                UriImg = "http://img.fifa.com/images/flags/4/nga.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 27,
                Name = "Ghana",
                UriImg = "http://img.fifa.com/images/flags/4/gha.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 28,
                Name = "EEUU",
                UriImg = "http://img.fifa.com/images/flags/4/usa.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 29,
                Name = "Bélgica",
                UriImg = "http://img.fifa.com/images/flags/4/bel.png"
            });

            teams.Add(new TeamModel()
            {
                Id = 30,
                Name = "Argelia",
                UriImg = "http://img.fifa.com/images/flags/4/alg.png"
            });

            // TODO: continuar

            return teams;
        }
    }
}