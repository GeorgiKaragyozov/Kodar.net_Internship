using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.Faculty
{
    public class FacultyDaoStorage
    {
        public static List<Model.Faculty> Faculties
          = new List<Model.Faculty>();

        public static IDictionary<long, Model.Faculty> Dictionary
            = new Dictionary<long, Model.Faculty>();

        static FacultyDaoStorage()
        {
            Model.Faculty Faculty1 = new Model.Faculty()
            {

            };

            Model.Faculty Faculty2 = new Model.Faculty()
            {

            };

            Model.Faculty Faculty3 = new Model.Faculty()
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
