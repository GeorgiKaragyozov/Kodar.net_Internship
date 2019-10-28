using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherStatus
{
    public class TeacherStatusDaoStorage
    {
        public static List<Model.Accounts.TeacherStatus> Statuses = new List<Model.Accounts.TeacherStatus>();

        public static IDictionary<long, Model.Accounts.TeacherStatus> Dictionary =
            new Dictionary<long, Model.Accounts.TeacherStatus>();

        static TeacherStatusDaoStorage()
        {
            Model.Accounts.TeacherStatus status1 = new Model.Accounts.TeacherStatus()
            {

            };

            Model.Accounts.TeacherStatus status2 = new Model.Accounts.TeacherStatus()
            {

            };

            Model.Accounts.TeacherStatus status3 = new Model.Accounts.TeacherStatus()
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
