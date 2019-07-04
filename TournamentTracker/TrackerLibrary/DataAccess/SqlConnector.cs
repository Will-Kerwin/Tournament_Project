using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
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
            model.Id = 1;

            return model;
        }
    }
}
