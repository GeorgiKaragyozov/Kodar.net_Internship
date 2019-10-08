using System;
using UniversityDemo.DataAccess.DataAccessObject.StudentStatus;

namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public class StudentStatusParamConverter: IStudentStatusParamConverter
    {
        public StudentStatusDao StudentStatusDao { get; set; }
    }
}
