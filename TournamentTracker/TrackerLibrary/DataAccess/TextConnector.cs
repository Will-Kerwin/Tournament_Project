using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the Create Prize for text files.
        /// <summary>
        /// Saves data to file
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
