using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus
{
    public class SpecialityStatusDaoStorage
    {
        public static List<UniversityDemo.SpecialityStatus> Statuses = new List<UniversityDemo.SpecialityStatus>();

        public static IDictionary<long, UniversityDemo.SpecialityStatus> Dictionary =
            new Dictionary<long, UniversityDemo.SpecialityStatus>();

        static SpecialityStatusDaoStorage()
        {
            UniversityDemo.SpecialityStatus status1 = new UniversityDemo.SpecialityStatus()
            {

            };

            UniversityDemo.SpecialityStatus status2 = new UniversityDemo.SpecialityStatus()
            {

            };

            UniversityDemo.SpecialityStatus status3 = new UniversityDemo.SpecialityStatus()
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
