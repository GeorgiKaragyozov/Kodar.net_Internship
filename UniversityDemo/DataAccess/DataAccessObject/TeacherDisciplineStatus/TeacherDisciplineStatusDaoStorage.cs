using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusDaoStorage
    {
        public static List<Data.Entity.Model.Status.TeacherDisciplineStatus> Statuses = 
            new List<Data.Entity.Model.Status.TeacherDisciplineStatus>();

        public static IDictionary<long, Data.Entity.Model.Status.TeacherDisciplineStatus> Dictionary =
            new Dictionary<long, Data.Entity.Model.Status.TeacherDisciplineStatus>();

        static TeacherDisciplineStatusDaoStorage()
        {
            Data.Entity.Model.Status.TeacherDisciplineStatus status1 = 
                new Data.Entity.Model.Status.TeacherDisciplineStatus()
            {

            };

            Data.Entity.Model.Status.TeacherDisciplineStatus status2 = 
                new Data.Entity.Model.Status.TeacherDisciplineStatus()
            {

            };

            Data.Entity.Model.Status.TeacherDisciplineStatus status3 =
                new Data.Entity.Model.Status.TeacherDisciplineStatus()
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
