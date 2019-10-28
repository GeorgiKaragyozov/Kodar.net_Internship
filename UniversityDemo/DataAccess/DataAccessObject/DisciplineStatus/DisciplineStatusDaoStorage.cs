using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus
{
    public class DisciplineStatusDaoStorage
    {
        public static List<UniversityDemo.DisciplineStatus> DisciplinesStatus
          = new List<UniversityDemo.DisciplineStatus>();

        public static IDictionary<long, UniversityDemo.DisciplineStatus> Dictionary
            = new Dictionary<long, UniversityDemo.DisciplineStatus>();

        static DisciplineStatusDaoStorage()
        {
            UniversityDemo.DisciplineStatus Discipline1 = new UniversityDemo.DisciplineStatus()
            {
                Id = 1,
                Description = ".NET ASP",
                Code = "1",
                Name = "Discipline",
            };

            UniversityDemo.DisciplineStatus Discipline2 = new UniversityDemo.DisciplineStatus()
            {
                Id = 2,
                Description = "mathematics",
                Code = "2",
                Name = "Discipline "
            };

            UniversityDemo.DisciplineStatus Discipline3 = new UniversityDemo.DisciplineStatus()
            {
                Id = 3,
                Description = "Data base",
                Code = "3",
                Name = "Discipline"
            };

            DisciplinesStatus.Add(Discipline1);
            DisciplinesStatus.Add(Discipline2);
            DisciplinesStatus.Add(Discipline3);

            Dictionary.Add(Discipline1.Id, Discipline1);
            Dictionary.Add(Discipline2.Id, Discipline2);
            Dictionary.Add(Discipline3.Id, Discipline3);
        }
    }
}
