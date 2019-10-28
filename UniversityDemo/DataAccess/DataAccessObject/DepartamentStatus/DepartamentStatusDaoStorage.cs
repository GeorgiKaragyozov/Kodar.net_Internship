using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus
{
    public class DepartamentStatusDaoStorage
    {
        public static List<UniversityDemo.DepartamentStatus> DepartamentsStatus
           = new List<UniversityDemo.DepartamentStatus>();

        public static IDictionary<long, UniversityDemo.DepartamentStatus> Dictionary
            = new Dictionary<long, UniversityDemo.DepartamentStatus>();

        static DepartamentStatusDaoStorage()
        {
            UniversityDemo.DepartamentStatus Status1 = new UniversityDemo.DepartamentStatus()
            {
                Id = 1,
                Description = "in repair",
                Code = "1",
                Name = "Departament Status"
            };

            UniversityDemo.DepartamentStatus Status2 = new UniversityDemo.DepartamentStatus()
            {
                Id = 2,
                Description = "closed",
                Code = "2",
                Name = "Departament Status"
            };

            UniversityDemo.DepartamentStatus Status3 = new UniversityDemo.DepartamentStatus()
            {
                Id = 3,
                Description = "doesn't work today",
                Code = "3",
                Name = "Departament Status"
            };

            DepartamentsStatus.Add(Status1);
            DepartamentsStatus.Add(Status2);
            DepartamentsStatus.Add(Status3);

            Dictionary.Add(Status1.Id, Status1);
            Dictionary.Add(Status2.Id, Status2);
            Dictionary.Add(Status3.Id, Status3);
        }
    }
}
