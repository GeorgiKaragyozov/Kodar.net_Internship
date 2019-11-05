using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherStatus
{
    public class TeacherStatusDaoStorage
    {
        public static List<Model.TeacherStatus> Statuses = new List<Model.TeacherStatus>();

        public static IDictionary<long, Model.TeacherStatus> Dictionary =
            new Dictionary<long, Model.TeacherStatus>();

        static TeacherStatusDaoStorage()
        {
            Model.TeacherStatus status1 = new Model.TeacherStatus()
            {

            };

            Model.TeacherStatus status2 = new Model.TeacherStatus()
            {

            };

            Model.TeacherStatus status3 = new Model.TeacherStatus()
            {

            };

            Statuses.Add(status1);
            Statuses.Add(status2);
            Statuses.Add(status3);

            Dictionary.Add(status1.Id, status1);
            Dictionary.Add(status2.Id, status2);
            Dictionary.Add(status3.Id, status3);
        }
    }
}
