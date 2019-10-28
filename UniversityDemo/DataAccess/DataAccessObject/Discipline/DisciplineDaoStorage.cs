using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.Discipline
{
    public class DisciplineDaoStorage
    {
        public static List<UniversityDemo.Discipline> Disciplines
           = new List<UniversityDemo.Discipline>();

        public static IDictionary<long, UniversityDemo.Discipline> Dictionary
            = new Dictionary<long, UniversityDemo.Discipline>();

        static DisciplineDaoStorage()
        {
            UniversityDemo.Discipline Discipline1 = new UniversityDemo.Discipline()
            {
                Id = 1,
                Description = ".NET ASP",
                Code = "1",
                Name = "Discipline",
            };

            UniversityDemo.Discipline Discipline2 = new UniversityDemo.Discipline()
            {
                Id = 2,
                Description = "mathematics",
                Code = "2",
                Name = "Discipline "
            };

            UniversityDemo.Discipline Discipline3 = new UniversityDemo.Discipline()
            {
                Id = 3,
                Description = "Data base",
                Code = "3",
                Name = "Discipline"
            };

            Disciplines.Add(Discipline1);
            Disciplines.Add(Discipline2);
            Disciplines.Add(Discipline3);

            Dictionary.Add(Discipline1.Id, Discipline1);
            Dictionary.Add(Discipline2.Id, Discipline2);
            Dictionary.Add(Discipline3.Id, Discipline3);
        }
    }
}
