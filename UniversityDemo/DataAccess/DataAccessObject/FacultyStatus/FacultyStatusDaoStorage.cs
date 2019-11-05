using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.FacultyStatus
{
    public class FacultyStatusDaoStorage
    {
        public static List<Model.FacultyStatus> FacultiesStatus
         = new List<Model.FacultyStatus>();

        public static IDictionary<long, Model.FacultyStatus> Dictionary
            = new Dictionary<long, Model.FacultyStatus>();

        static FacultyStatusDaoStorage()
        {
            Model.FacultyStatus FacultyStatus1 = new Model.FacultyStatus()
            {

            };

            Model.FacultyStatus FacultyStatus2 = new Model.FacultyStatus()
            {

            };

            Model.FacultyStatus FacultyStatus3 = new Model.FacultyStatus()
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
