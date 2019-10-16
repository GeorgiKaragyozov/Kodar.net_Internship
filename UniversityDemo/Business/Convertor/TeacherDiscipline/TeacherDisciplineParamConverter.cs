using System;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDiscipline;

namespace UniversityDemo.Business.Convertor.TeacherDiscipline
{
    public class TeacherDisciplineParamConverter: ITeacherDisciplineParamConverter
    {
        public TeacherDisciplineDao Dao { get; set; }

        public Model.TeacherDiscipline Convert(TeacherDisciplineParam param)
        {
            throw new NotImplementedException();
        }
    }
}
