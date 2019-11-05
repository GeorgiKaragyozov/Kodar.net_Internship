using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.Departament
{
    public class DepartamentDaoStorage
    {
        public static List<Model.Departament> Departaments
            = new List<Model.Departament>();

        public static IDictionary<long, Model.Departament> Dictionary
            = new Dictionary<long, Model.Departament>();

        static DepartamentDaoStorage()
        {
            Model.Teacher teacher = new Model.Teacher();

            Model.Departament departament1 = new Model.Departament()
            {
                Id = 1,
                Description = "something",
                Code = "1",
                Name = "Departament",
                Teacher = teacher,
            };

            Model.Departament departament2 = new Model.Departament()
            {
                Id = 2,
                Description = "something",
                Code = "2",
                Name = "Departament",
                Teacher = teacher,
            };

            Model.Departament departament3 = new Model.Departament()
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
