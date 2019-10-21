using System;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus;

namespace UniversityDemo.Business.Convertor.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusParamConverter: ITeacherDisciplineStatusParamConverter
    {
        public ITeacherDisciplineStatusDao Dao { get; set; }

        public TeacherDisciplineStatusParamConverter(ITeacherDisciplineStatusDao dao)
        {
            this.Dao = dao;
        }

        public Data.Entity.Model.Status.TeacherDisciplineStatus Convert(TeacherDisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
