using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.UserStatus
{
    public class UserStatusDaoStorage
    {
        public static List<UniversityDemo.UserStatus> Statuses = new List<UniversityDemo.UserStatus>();

        public static IDictionary<long, UniversityDemo.UserStatus> Dictionary =
            new Dictionary<long, UniversityDemo.UserStatus>();

        static UserStatusDaoStorage()
        {
            UniversityDemo.UserStatus status1 = new UniversityDemo.UserStatus()
            {

            };

            UniversityDemo.UserStatus status2 = new UniversityDemo.UserStatus()
            {

            };

            UniversityDemo.UserStatus status3 = new UniversityDemo.UserStatus()
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
