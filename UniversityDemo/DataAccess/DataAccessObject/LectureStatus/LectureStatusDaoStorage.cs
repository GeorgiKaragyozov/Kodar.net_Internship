using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.LectureStatus
{
    public class LectureStatusDaoStorage
    {
        public static List<Data.Entity.Model.Status.LectureStatus> LecturesStatus = 
            new List<Data.Entity.Model.Status.LectureStatus>();

        public static IDictionary<long, Data.Entity.Model.Status.LectureStatus> Dictionary =
            new Dictionary<long, Data.Entity.Model.Status.LectureStatus>();

        static LectureStatusDaoStorage()
        {
            Data.Entity.Model.Status.LectureStatus status = new Data.Entity.Model.Status.LectureStatus()
            {

            };

            Data.Entity.Model.Status.LectureStatus status1 = new Data.Entity.Model.Status.LectureStatus()
            {

            };

            Data.Entity.Model.Status.LectureStatus status2 = new Data.Entity.Model.Status.LectureStatus()
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
