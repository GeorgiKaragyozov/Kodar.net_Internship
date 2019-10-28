using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.Departament
{
    public class DepartamentDaoStorage
    {
        public static List<UniversityDemo.Departament> Departaments
            = new List<UniversityDemo.Departament>();

        public static IDictionary<long, UniversityDemo.Departament> Dictionary
            = new Dictionary<long, UniversityDemo.Departament>();

        static DepartamentDaoStorage()
        {
            UniversityDemo.Teacher teacher = new UniversityDemo.Teacher();

            UniversityDemo.Departament departament1 = new UniversityDemo.Departament()
            {
                Id = 1,
                Description = "something",
                Code = "1",
                Name = "Departament",
                Teacher = teacher,
            };

            UniversityDemo.Departament departament2 = new UniversityDemo.Departament()
            {
                Id = 2,
                Description = "something",
                Code = "2",
                Name = "Departament",
                Teacher = teacher,
            };

            UniversityDemo.Departament departament3 = new UniversityDemo.Departament()
            {
                Id = 3,
                Description = "something",
                Code = "3",
                Name = "Departament",
                Teacher = teacher,
            };

            Departaments.Add(departament1);
            Departaments.Add(departament2);
            Departaments.Add(departament3);

            Dictionary.Add(departament1.Id, departament1);
            Dictionary.Add(departament2.Id, departament2);
            Dictionary.Add(departament3.Id, departament3);
        }
    }
}
