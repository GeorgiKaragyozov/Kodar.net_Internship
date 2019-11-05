using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.StudentStatus
{
    public class StudentStatusDaoStorage
    {
        public static List<Model.StudentStatus> Statuses = new List<Model.StudentStatus>();

        public static IDictionary<long, Model.StudentStatus> Dictionary =
            new Dictionary<long, Model.StudentStatus>();

        static StudentStatusDaoStorage()
        {
            Model.StudentStatus status1 = new Model.StudentStatus()
            {

            };

            Model.StudentStatus status2 = new Model.StudentStatus()
            {

            };

            Model.StudentStatus status3 = new Model.StudentStatus()
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
