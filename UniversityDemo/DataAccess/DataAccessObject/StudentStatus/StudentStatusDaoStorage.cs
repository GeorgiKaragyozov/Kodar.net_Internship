using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.StudentStatus
{
    public class StudentStatusDaoStorage
    {
        public static List<UniversityDemo.StudentStatus> Statuses = new List<UniversityDemo.StudentStatus>();

        public static IDictionary<long, UniversityDemo.StudentStatus> Dictionary =
            new Dictionary<long, UniversityDemo.StudentStatus>();

        static StudentStatusDaoStorage()
        {
            UniversityDemo.StudentStatus status1 = new UniversityDemo.StudentStatus()
            {

            };

            UniversityDemo.StudentStatus status2 = new UniversityDemo.StudentStatus()
            {

            };

            UniversityDemo.StudentStatus status3 = new UniversityDemo.StudentStatus()
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
