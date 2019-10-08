using System;
using UniversityDemo.Business.Processor.Student;

namespace UniversityDemo.Presentation.Service.Student
{
    public class StudentService: IStudentService
    {
        public StudentProcessor StudentProcessor { get; set; }
    }
}
