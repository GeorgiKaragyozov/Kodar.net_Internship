using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.FacultyStatus
{
    public class FacultyStatusDaoStorage
    {
        public static List<UniversityDemo.FacultyStatus> FacultiesStatus
         = new List<UniversityDemo.FacultyStatus>();

        public static IDictionary<long, UniversityDemo.FacultyStatus> Dictionary
            = new Dictionary<long, UniversityDemo.FacultyStatus>();

        static FacultyStatusDaoStorage()
        {
            UniversityDemo.FacultyStatus FacultyStatus1 = new UniversityDemo.FacultyStatus()
            {

            };

            UniversityDemo.FacultyStatus FacultyStatus2 = new UniversityDemo.FacultyStatus()
            {

            };

            UniversityDemo.FacultyStatus FacultyStatus3 = new UniversityDemo.FacultyStatus()
            {

            };

            FacultiesStatus.Add(FacultyStatus1);
            FacultiesStatus.Add(FacultyStatus2);
            FacultiesStatus.Add(FacultyStatus3);

            Dictionary.Add(FacultyStatus1.Id, FacultyStatus1);
            Dictionary.Add(FacultyStatus2.Id, FacultyStatus2);
            Dictionary.Add(FacultyStatus3.Id, FacultyStatus3);
        }
    }
}
