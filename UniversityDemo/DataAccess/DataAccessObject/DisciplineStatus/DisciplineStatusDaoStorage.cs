using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus
{
    public class DisciplineStatusDaoStorage
    {
        public static List<Model.DisciplineStatus> DisciplinesStatus
          = new List<Model.DisciplineStatus>();

        public static IDictionary<long, Model.DisciplineStatus> Dictionary
            = new Dictionary<long, Model.DisciplineStatus>();

        static DisciplineStatusDaoStorage()
        {
            Model.DisciplineStatus Discipline1 = new Model.DisciplineStatus()
            {
                Id = 1,
                Description = ".NET ASP",
                Code = "1",
                Name = "Discipline",
            };

            Model.DisciplineStatus Discipline2 = new Model.DisciplineStatus()
            {
                Id = 2,
                Description = "mathematics",
                Code = "2",
                Name = "Discipline "
            };

            Model.DisciplineStatus Discipline3 = new Model.DisciplineStatus()
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
