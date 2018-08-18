# NationalStudentClearingHouse.ETransConnector
Passed school and student information to National Student Clearing House and returns html content to forward user to endpoint.


Example:

            var config = new ClearingHouseConfig();
            var mgr = new NationalStudentClearingHouse.ETranscriptsConnector.Manager.ClearingHouseManager(config);
            var result = mgr.GetAuthenticationResponse(studentId);
            Response.Write(result);
