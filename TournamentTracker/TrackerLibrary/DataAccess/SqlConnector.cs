using Dapper;
using System.Data;
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
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
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

        // TODO - Make the create prize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// 
        /// we are going to be using dapper to connect to sql 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>the prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // planning is key causes less hassle in the long term plan even when code is written 
            // using says that they want to wrap so when we hit the } it gets distroyed this is to prevent memory leaks 
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
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
    }
}
