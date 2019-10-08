using System;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus;

namespace UniversityDemo.Business.Convertor.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusParamConverter: ITeacherDisciplineStatusParamConverter
    {
        public TeacherDisciplineStatusDao TeacherDisciplineStatusDao { get; set; }
    }
}
