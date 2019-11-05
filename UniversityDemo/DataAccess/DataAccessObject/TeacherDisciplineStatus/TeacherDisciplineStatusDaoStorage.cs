using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusDaoStorage
    {
        public static List<Model.TeacherDisciplineStatus> Statuses = 
            new List<Model.TeacherDisciplineStatus>();

        public static IDictionary<long, Model.TeacherDisciplineStatus> Dictionary =
            new Dictionary<long, Model.TeacherDisciplineStatus>();

        static TeacherDisciplineStatusDaoStorage()
        {
            Model.TeacherDisciplineStatus status1 = 
                new Model.TeacherDisciplineStatus()
            {

            };

            Model.TeacherDisciplineStatus status2 = 
                new Model.TeacherDisciplineStatus()
            {

            };

            Model.TeacherDisciplineStatus status3 =
                new Model.TeacherDisciplineStatus()
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
