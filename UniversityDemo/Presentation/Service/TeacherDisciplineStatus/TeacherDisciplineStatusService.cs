using System;
using UniversityDemo.Business.Processor.TeacherDisciplineStatus;

namespace UniversityDemo.Presentation.Service.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusService: ITeacherDisciplineStatusService
    {
        public TeacherDisciplineStatusProcessor Processor { get; set; }
    }
}
