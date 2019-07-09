using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    // in order to have extensions we must have a separate static class

    // PLAN * = done
    // * load the text file 
    // * convert the text to List<PrizeModel>
    // Find the id
    // Add teh new record with the new ID
    // convert the prizes to list<string>
    // save the list<string> to text file

    public static class TextConnectorProcessor
    {
        /// <summary>
        /// Will Return the full File path of a file given in a string format.
        /// (THIS string fileName) allows for us to make it an extension so we can do string.FullFilePath
        /// </summary>
        /// <param name="fileName">File Name in string</param>
        /// <returns>Full File Path</returns>
        public static string FullFilePath(this string fileName)
        {
            // $"" allows to concatonate strings together
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{fileName}";
            // par example C:\dir\dir\fileName
        }

        /// <summary>
        /// Loads file and puts all lines into a list
        /// </summary>
        /// <param name="file">File Name</param>
        /// <returns>List version of loaded file</returns>
        public static List<string> LoadFile(this string file)
        {
            // if not a file that exists retun t or f
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        /* Convert to models */

        /// <summary>
        /// takes text from csv parses and splits string to be put into prize model
        /// </summary>
        /// <param name="lines">a list of strings from LoadFile</param>
        /// <returns>Prize Model</returns>
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {

            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                // splitting each line into comma separated and adding into an array 
                // this will be sorted out when we save etc etc just have to know teh array cols position
                string[] cols = line.Split(',');

                PrizeModel pm = new PrizeModel();

                // sometime better to crash then limp with half formed data 
                // so if this doesnt work its gonna crash
                pm.Id = int.Parse(cols[0]);
                pm.PlaceNumber = int.Parse(cols[1]);
                pm.PlaceName = cols[2];
                pm.PrizeAmount = decimal.Parse(cols[3]);
                pm.PrizePercentage = double.Parse(cols[4]);
                output.Add(pm);
            }

            return output;
        }

        /// <summary>
        /// Converts list of strings to person model
        /// </summary>
        /// <param name="lines">list of strings from load file</param>
        /// <returns>Person Model</returns>
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            // Comments are same as prize model look to there for same thing i feel like this is code duplication but oh well
            // TODO - look into library called auto mapper which should fix comment above
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel pm = new PersonModel();

                pm.Id = int.Parse(cols[0]);
                pm.FirstName = cols[1];
                pm.LastName = cols[2];
                pm.EmailAddress = cols[3];
                pm.MobilePhoneNumber = cols[4];

                output.Add(pm);
            }

            return output;
        }

        /* Save To Files */

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel prizeModel in models)
            {
                lines.Add($"{ prizeModel.Id },{ prizeModel.PlaceNumber },{ prizeModel.PlaceName },{ prizeModel.PrizeAmount },{ prizeModel.PrizePercentage }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel person in models)
            {
                lines.Add($"{person.Id},{person.FirstName},{person.LastName},{person.EmailAddress},{person.MobilePhoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}