using Brasil2014.Data;
using Brasil2014.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brasil2014.Impl
{
    public class MatchRepository : IMatchRepository
    {
        public List<MatchModel> GetMathes(List<TeamModel> teamModel)
        {
            List<MatchModel> matches = new List<MatchModel>(48);

            matches.Add(new MatchModel()
                {
                    NumGame = 1,
                    Team1 = teamModel[0],
                    Team2 = teamModel[1]
                });
            matches.Add(new MatchModel()
            {
                NumGame = 2,
                Team1 = teamModel[2],
                Team2 = teamModel[3]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 3,
                Team1 = teamModel[4],
                Team2 = teamModel[5]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 4,
                Team1 = teamModel[6],
                Team2 = teamModel[7]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 5,
                Team1 = teamModel[8],
                Team2 = teamModel[9]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 6,
                Team1 = teamModel[10],
                Team2 = teamModel[11]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 7,
                Team1 = teamModel[12],
                Team2 = teamModel[13]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 8,
                Team1 = teamModel[14],
                Team2 = teamModel[15]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 9,
                Team1 = teamModel[16],
                Team2 = teamModel[17]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 10,
                Team1 = teamModel[18],
                Team2 = teamModel[19]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 11,
                Team1 = teamModel[20],
                Team2 = teamModel[21]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 12,
                Team1 = teamModel[22],
                Team2 = teamModel[23]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 13,
                Team1 = teamModel[24],
                Team2 = teamModel[25]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 14,
                Team1 = teamModel[26],
                Team2 = teamModel[27]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 15,
                Team1 = teamModel[28],
                Team2 = teamModel[29]
            });

			matches.Add(new MatchModel()
				{
					NumGame = 16,
					Team1 = teamModel[0],
					Team2 = teamModel[2]
				});

			matches.Add(new MatchModel()
				{
					NumGame = 17,
					Team1 = teamModel[30],
					Team2 = teamModel[31]
				});


            matches.Add(new MatchModel()
            {
                NumGame = 18,
                Team1 = teamModel[7],
                Team2 = teamModel[5]
            });

            matches.Add(new MatchModel()
            {
                NumGame = 19,
                Team1 = teamModel[4],
                Team2 = teamModel[6],
                Result = "2"

            });
            // TODO: continuar

            return matches;
        }
    }
}