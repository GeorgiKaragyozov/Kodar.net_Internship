using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.AccountStatus
{
    public class AccountStatusStorage
    {
        public static List<Model.AccountStatus> AccountStatuses = new List<Model.AccountStatus>();

        public static Dictionary<long, Model.AccountStatus> Dictionary = new Dictionary<long, Model.AccountStatus>();

        static AccountStatusStorage()
        {
            Model.AccountStatus status1 = new Model.AccountStatus()
            {
                Id = 1,
                Description = "something",
                Code = "1",
                Name = "Status1"
            };

            Model.AccountStatus status2 = new Model.AccountStatus()
            {
                Id = 2,
                Description = "something",
                Code = "1",
                Name = "Status2"
            };

            Model.AccountStatus status3 = new Model.AccountStatus()
            {
                Id = 3,
                Description = "something",
                Code = "1",
                Name = "Status3"
            };

            Model.AccountStatus status4 = new Model.AccountStatus()
            {
                Id = 4,
                Description = "something",
                Code = "1",
                Name = "Status4"
            };

            Model.AccountStatus status5 = new Model.AccountStatus()
            {
                Id = 5,
                Description = "something",
                Code = "1",
                Name = "Status4"
            };

            AccountStatuses.Add(status1);
            AccountStatuses.Add(status2);
            AccountStatuses.Add(status3);
            AccountStatuses.Add(status4);
            AccountStatuses.Add(status5);

            Dictionary.Add(status1.Id, status1);
            Dictionary.Add(status2.Id, status2);
            Dictionary.Add(status3.Id, status3);
            Dictionary.Add(status4.Id, status4);
            Dictionary.Add(status5.Id, status5);
        }
    }
}
