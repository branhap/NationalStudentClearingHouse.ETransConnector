using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace NationalStudentClearingHouse.ETranscriptsConnector.Manager
{
    public class ClearingHouseManager
    {
        private ClearingHouseConfig config;

        public ClearingHouseManager (ClearingHouseConfig schoolConfig)
        {
            config = schoolConfig;
        }

        public ClearingHouseManager()
        {
            config = new ClearingHouseConfig();
        }

        /// <summary>
        /// Gets the URL to send the student to when they attempt to authenticate.
        /// </summary>
        /// <param name="studentId"></param>
        public string GetAuthenticationResponse(string studentId)
        {
            var hwr = (HttpWebRequest)WebRequest.Create(config.Link);
            hwr.AllowAutoRedirect = true;
            hwr.MaximumAutomaticRedirections = 5;
            hwr.ContentType = config.ContentType;
            hwr.Referer = config.Referer;
            hwr.UserAgent = config.UserAgent;
            hwr.Method = config.RequestMethod;

            Stream requestStream = hwr.GetRequestStream();
            StreamWriter streamWriter = new StreamWriter(requestStream);
            streamWriter.Write(GenerateWebRequestBody(studentId));
            streamWriter.Close();

            var webResponse = hwr.GetResponse();
            var streamResponse = webResponse.GetResponseStream();
            var streamReader = new StreamReader(streamResponse);

            var response = streamReader.ReadToEnd();
            streamReader.Close();

            return response;
        }

        private string GenerateWebRequestBody(string studentId)
        {
            return "user_id=" + config.UserName + "&password=" + config.Password + "&id=" + studentId + "&pathtype=" + config.PathType;
        }
    }
}
