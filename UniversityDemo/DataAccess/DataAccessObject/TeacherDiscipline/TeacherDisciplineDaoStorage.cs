using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherDiscipline
{
    public class TeacherDisciplineDaoStorage
    {
        public static List<Model.TeacherDiscipline> teacherDisciplines = new List<Model.TeacherDiscipline>();

        public static IDictionary<long, Model.TeacherDiscipline> Dictionary =
            new Dictionary<long, Model.TeacherDiscipline>();

        static TeacherDisciplineDaoStorage()
        {
            Model.TeacherDiscipline discipline1 = new Model.TeacherDiscipline()
            {

            };

            Model.TeacherDiscipline discipline2 = new Model.TeacherDiscipline()
            {

            };

            Model.TeacherDiscipline discipline3 = new Model.TeacherDiscipline()
            {

            };

            teacherDisciplines.Add(discipline1);
            teacherDisciplines.Add(discipline2);
            teacherDisciplines.Add(discipline3);

            Dictionary.Add(discipline1.Id, discipline1);
            Dictionary.Add(discipline2.Id, discipline2);
            Dictionary.Add(discipline3.Id, discipline3);
        }
    }
}
