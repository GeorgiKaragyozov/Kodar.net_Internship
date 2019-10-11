using System;
using UniversityDemo.Business.Convertor.StudentStatus;
using UniversityDemo.DataAccess.DataAccessObject.StudentStatus;

namespace UniversityDemo.Business.Processor.StudentStatus
{
    public class StudentStatusProcessor: IStudentStatusProcessor
    {
        public StudentStatusDao StudentStatusDao { get; set; }

        public StudentStatusParamConverter StudentStatusParamConverter { get; set; }

        public StudentStatusResultConverter StudentStatusResultConverter { get; set; }
    }
}
