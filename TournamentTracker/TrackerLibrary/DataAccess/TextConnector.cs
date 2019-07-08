using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    /*
     * Plan Plan Plan do your plan first fill in code inbetween 
     */

    
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModel.csv";

        // TODO - Wire up the Create Prize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // abstraction its compact readable etc etc
            // * load the text file 
            // * convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // finds id of highiest id in list then get that id and add one to it. this is what we use to write current record.
            // * Find the max id
            int currentId = 1;
            // if there is no record make id 1
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // * Add the new record with the new ID
            prizes.Add(model);

            // * convert the prizes to list<string>
            // * save the list<string> to text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
