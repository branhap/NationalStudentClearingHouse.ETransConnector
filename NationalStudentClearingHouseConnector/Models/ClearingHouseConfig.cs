using System;

namespace NationalStudentClearingHouse.ETranscriptsConnector
{
    public class ClearingHouseConfig
    {
        /// <summary>
        /// User name assigned to School.
        /// </summary>
        public string UserName { get; set; } = "username";

        /// <summary>
        /// Password that allows school to log into National Student Clearing House.
        /// </summary>
        public string Password { get; set; } = "password";

        /// <summary>
        /// Web App that is sending the request.
        /// </summary>
        public string Referer { get; set; } = "https://example.edu/eTransConnector";

        /// <summary>
        /// Setting provided by National Student Clearing House and passed to them.
        /// </summary>
        public string PathType { get; set; } = "P";

        /// <summary>
        /// URL to send the request to.
        /// </summary>
        public string Link { get; set; } = "https://secure.studentclearinghouse.org/sssportalui/authenticate";

        /// <summary>
        /// The Content Type for the request.
        /// </summary>
        public string ContentType { get; set; } = "application/x-www-form-urlencoded;";

        /// <summary>
        /// Web Request User Agent
        /// </summary>
        public string UserAgent { get; set; } = "msie 5.5";

        public string RequestMethod { get; set; } = "POST";
    }
}
