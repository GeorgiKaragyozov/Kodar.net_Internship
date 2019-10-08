using System;
using UniversityDemo.DataAccess.DataAccessObject.Student;

namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentParamConverter: IStudentParamConverter
    {
        public StudentDao StudentDao { get; set; }
    }
}
