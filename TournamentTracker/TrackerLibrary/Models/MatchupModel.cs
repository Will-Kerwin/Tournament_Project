using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The Entries.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The Winner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// The number round it is.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
