using System;
using UniversityDemo.Business.Processor.TeacherDiscipline;

namespace UniversityDemo.Presentation.Service.TeacherDiscipline
{
    public class TeacherDisciplineService: ITeacherDisciplineService
    {
        public TeacherDisciplineProcessor Processor { get; set; }
    }
}
