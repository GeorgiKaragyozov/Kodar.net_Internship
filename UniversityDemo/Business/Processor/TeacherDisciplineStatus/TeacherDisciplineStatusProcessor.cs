using System;
using UniversityDemo.Business.Convertor.TeacherDisciplineStatus;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus;

namespace UniversityDemo.Business.Processor.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusProcessor: ITeacherDisciplineStatusProcessor
    {
        public TeacherDisciplineStatusDao TeacherDisciplineStatusDao { get; set; }

        public TeacherDisciplineStatusParamConverter TeacherDisciplineParamConverter { get; set; }

        public TeacherDisciplineStatusResultConverter TeacherDisciplineResultConverter { get; set; }
    }
}
