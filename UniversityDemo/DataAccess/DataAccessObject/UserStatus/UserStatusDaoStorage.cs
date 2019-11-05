using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.UserStatus
{
    public class UserStatusDaoStorage
    {
        public static List<Model.UserStatus> Statuses = new List<Model.UserStatus>();

        public static IDictionary<long, Model.UserStatus> Dictionary =
            new Dictionary<long, Model.UserStatus>();

        static UserStatusDaoStorage()
        {
            Model.UserStatus status1 = new Model.UserStatus()
            {

            };

            Model.UserStatus status2 = new Model.UserStatus()
            {

            };

            Model.UserStatus status3 = new Model.UserStatus()
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
