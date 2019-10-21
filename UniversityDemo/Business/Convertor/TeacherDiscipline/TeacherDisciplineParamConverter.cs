using System;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDiscipline;

namespace UniversityDemo.Business.Convertor.TeacherDiscipline
{
    public class TeacherDisciplineParamConverter: ITeacherDisciplineParamConverter
    {
        public ITeacherDisciplineDao Dao { get; set; }

        public TeacherDisciplineParamConverter(ITeacherDisciplineDao dao)
        {
            this.Dao = dao;
        }

        public Model.TeacherDiscipline Convert(TeacherDisciplineParam param)
        {
            throw new NotImplementedException();
        }
    }
}
