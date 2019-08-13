using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TrackerLibrary.Models;

/*
 * @PlaceNumber int,
@PlaceName nvarchar(50),
@PrizeAmount money,
@PrizePercentage float,
@id int = 0 output
*/
namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string database = "Tournaments";

        /*Create Models 
         *Saves a new prize to the database
         *we are going to be using dapper to connect to sql 
         */

        /// <summary>
        /// Passes in a Person model to create it on the sql side
        /// </summary>
        /// <param name="model">TeamModel</param>
        /// <returns>The Person Model, including the unique identifier</returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var dp = new DynamicParameters();

                // @'s are for sql ref
                dp.Add("@FirstName", model.FirstName);
                dp.Add("@LastName", model.LastName);
                dp.Add("@EmailAddress", model.EmailAddress);
                dp.Add("@MobilePhoneNumber", model.MobilePhoneNumber);
                dp.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", dp, commandType: CommandType.StoredProcedure);

                model.Id = dp.Get<int>("@id");

                // what happens if things go wrong?
                return model;
            }
        }
        /// <summary>
        /// Passes in a Prize model to create it on the sql side
        /// </summary>
        /// <param name="model">PrizeModel</param>
        /// <returns>The Prize Model, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // planning is key causes less hassle in the long term plan even when code is written 
            // using says that they want to wrap so when we hit the } it gets distroyed this is to prevent memory leaks 
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var dp = new DynamicParameters();

                dp.Add("@PlaceNumber", model.PlaceNumber);
                dp.Add("@PlaceName", model.PlaceName);
                dp.Add("@PrizeAmount", model.PrizeAmount);
                dp.Add("@PrizePercentage", model.PrizePercentage);
                dp.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", dp, commandType: CommandType.StoredProcedure);

                model.Id = dp.Get<int>("@id");
                // what happens if things go wrong?
                return model;
            }
        }
        /// <summary>
        /// Passes in a Team model to create it on the sql side
        /// </summary>
        /// <param name="model">TeamModel</param>
        /// <returns>The Team Model including the unique identifier</returns>
        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var dp = new DynamicParameters();

                // @'s are for sql ref
                dp.Add("@TeamName", model.TeamName);
                dp.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", dp, commandType: CommandType.StoredProcedure);

                model.Id = dp.Get<int>("@id");

                foreach (PersonModel tm in model.TeamMembers)
                {
                    dp = new DynamicParameters();

                    // @'s are for sql ref
                    dp.Add("@TeamId", model.Id);
                    dp.Add("@PersonId", tm.Id);

                    connection.Execute("dbo.spTeamMembers_Insert", dp, commandType: CommandType.StoredProcedure);
                }

                return model;
            }
        }

        /*Get Models*/

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }

        public List<TeamModel> GetTeam_All()
        {
            //TODO - implement on sql server when get home to desktop
            List<TeamModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                // TODO - look to person model see theres a team list need to do sp
                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);

                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }
    }
}
