using System;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus;

namespace UniversityDemo.Business.Convertor.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusParamConverter: ITeacherDisciplineStatusParamConverter
    {
        public TeacherDisciplineStatusDao Dao { get; set; }

        public Data.Entity.Model.Status.TeacherDisciplineStatus Convert(TeacherDisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
