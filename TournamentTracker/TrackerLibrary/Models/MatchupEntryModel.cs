namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one Team in the Matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents The Score For this particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// represents the matchup that this team came 
        /// from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        /// <summary>
        /// these are xml comments which are cool and 
        /// add stuff like the paramaters
        /// It is cool becasue for examplpe Consol.WriteLine(); 
        /// hover over and look details well this provides the details
        /// </summary>
        /// <param name="initialScore">
        /// can doc param notes
        /// </param>
        /// < <-- if i open up tag can do all cool things 
        public MatchupEntryModel(double initialScore)
        {
        }
    }
}
