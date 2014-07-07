using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brasil2014.Model
{
    public class MatchModel
    {
        public int NumGame { get; set; }

        public TeamModel Team1 { get; set; }

        public TeamModel Team2 { get; set; }

        public String Prophecy { get; set; }

        public String Result { get; set; }
    }
}