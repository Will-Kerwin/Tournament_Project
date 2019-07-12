using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Id number of team
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The allocated name for the team
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// The list of members of said team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

    }
}
