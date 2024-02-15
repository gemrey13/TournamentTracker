using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; } = new TeamModel();
        public double Score { get; set; }
        public MatchupModel? ParentMatchup { get; set; }

    }
}
