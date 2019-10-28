using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.AccountStatus
{
    public class AccountStatusStorage
    {
        public static List<UniversityDemo.AccountStatus> AccountStatuses = new List<UniversityDemo.AccountStatus>();

        public static IDictionary<long, UniversityDemo.AccountStatus> Dictionary = new Dictionary<long, UniversityDemo.AccountStatus>();

        static AccountStatusStorage()
        {
            UniversityDemo.AccountStatus status1 = new UniversityDemo.AccountStatus()
            {
                Id = 1,
                Description = "something",
                Code = "1",
                Name = "Status1"
            };

            UniversityDemo.AccountStatus status2 = new UniversityDemo.AccountStatus()
            {
                Id = 2,
                Description = "something",
                Code = "1",
                Name = "Status2"
            };

            UniversityDemo.AccountStatus status3 = new UniversityDemo.AccountStatus()
            {
                Id = 3,
                Description = "something",
                Code = "1",
                Name = "Status3"
            };

            UniversityDemo.AccountStatus status4 = new UniversityDemo.AccountStatus()
            {
                Id = 4,
                Description = "something",
                Code = "1",
                Name = "Status4"
            };

            AccountStatuses.Add(status1);
            AccountStatuses.Add(status2);
            AccountStatuses.Add(status3);
            AccountStatuses.Add(status4);

            Dictionary.Add(status1.Id, status1);
            Dictionary.Add(status2.Id, status2);
            Dictionary.Add(status3.Id, status3);
            Dictionary.Add(status4.Id, status4);
        }
    }
}
