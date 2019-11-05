using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus
{
    public class SpecialityStatusDaoStorage
    {
        public static List<Model.SpecialityStatus> Statuses = new List<Model.SpecialityStatus>();

        public static IDictionary<long, Model.SpecialityStatus> Dictionary =
            new Dictionary<long, Model.SpecialityStatus>();

        static SpecialityStatusDaoStorage()
        {
            Model.SpecialityStatus status1 = new Model.SpecialityStatus()
            {

            };

            Model.SpecialityStatus status2 = new Model.SpecialityStatus()
            {

            };

            Model.SpecialityStatus status3 = new Model.SpecialityStatus()
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
