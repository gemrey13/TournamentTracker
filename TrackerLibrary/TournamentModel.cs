using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal class TournamentModel
    {
        public string TournamentName { get; set; }
        public string EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
