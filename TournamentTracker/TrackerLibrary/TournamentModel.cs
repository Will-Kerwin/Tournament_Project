using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Tournament name.
        /// </summary>
        public string TournamentName{ get; set; }
        /// <summary>
        /// Price Of entry
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Teames Enterd
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// The Prizez
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel> ();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
