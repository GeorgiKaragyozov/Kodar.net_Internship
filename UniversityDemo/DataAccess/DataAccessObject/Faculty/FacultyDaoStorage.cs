using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.Faculty
{
    public class FacultyDaoStorage
    {
        public static List<UniversityDemo.Faculty> Faculties
          = new List<UniversityDemo.Faculty>();

        public static IDictionary<long, UniversityDemo.Faculty> Dictionary
            = new Dictionary<long, UniversityDemo.Faculty>();

        static FacultyDaoStorage()
        {
            UniversityDemo.Faculty Faculty1 = new UniversityDemo.Faculty()
            {

            };

            UniversityDemo.Faculty Faculty2 = new UniversityDemo.Faculty()
            {

            };

            UniversityDemo.Faculty Faculty3 = new UniversityDemo.Faculty()
            {

            };

            Faculties.Add(Faculty1);
            Faculties.Add(Faculty2);
            Faculties.Add(Faculty3);

            Dictionary.Add(Faculty1.Id, Faculty1);
            Dictionary.Add(Faculty2.Id, Faculty2);
            Dictionary.Add(Faculty3.Id, Faculty3);
        }
    }
}
