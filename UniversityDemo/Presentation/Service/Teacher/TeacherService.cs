using System;
using UniversityDemo.Business.Processor.Teacher;
using UniversityDemo.Presentation.Service.Teacher;

namespace UniversityDemoPresentation.Service.Teacher
{
    public class TeacherService: ITeacherService
    {
        public TeacherProcessor Processor { get; set; }
    }
}
