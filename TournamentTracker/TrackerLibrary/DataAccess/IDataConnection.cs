using System.Collections.Generic;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        /*Create Models*/
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        TeamModel CreateTeam(TeamModel model);
        /*Get Models*/
        List<PersonModel> GetPerson_All();
        List<TeamModel> GetTeam_All();
    }
}
