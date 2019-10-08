using System;
using UniversityDemo.Business.Processor.StudentStatus;

namespace UniversityDemo.Presentation.Service.StudentStatus
{
    public class StudentStatusService: IStudentStatusService
    {
        public StudentStatusProcessor StudentStatusProcessor { get; set; }
    }
}
