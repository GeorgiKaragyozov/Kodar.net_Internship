using System;
using UniversityDemo.Business.Convertor.TeacherDiscipline;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDiscipline;

namespace UniversityDemo.Business.Processor.TeacherDiscipline
{
    public class TeacherDisciplineProcessor: ITeacherDisciplineProcessor
    {
        public TeacherDisciplineDao TeacherDisciplineStatusDao { get; set; }

        public TeacherDisciplineParamConverter TeacherDisciplineParamConverter { get; set; }

        public TeacherDisciplineResultConverter TeacherDisciplineResultConverter { get; set; }
    }
}
