namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Unique id for the person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// First name of the person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of the person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email address of the person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Mobile telephone number of the person
        /// </summary>
        public string MobilePhoneNumber { get; set; }
    }
}
