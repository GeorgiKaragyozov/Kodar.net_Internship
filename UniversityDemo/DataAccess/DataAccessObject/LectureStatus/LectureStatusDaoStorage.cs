using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.LectureStatus
{
    public class LectureStatusDaoStorage
    {
        public static List<Model.LectureStatus> LecturesStatus = 
            new List<Model.LectureStatus>();

        public static IDictionary<long, Model.LectureStatus> Dictionary =
            new Dictionary<long, Model.LectureStatus>();

        static LectureStatusDaoStorage()
        {
            Model.LectureStatus status = new Model.LectureStatus()
            {

            };

            Model.LectureStatus status1 = new Model.LectureStatus()
            {

            };

            Model.LectureStatus status2 = new Model.LectureStatus()
            {

            };

            LecturesStatus.Add(status);
            LecturesStatus.Add(status1);
            LecturesStatus.Add(status2);

            Dictionary.Add(status.Id, status);
            Dictionary.Add(status1.Id, status1);
            Dictionary.Add(status2.Id, status2);
        }
    }
}
