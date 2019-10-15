using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Student;

namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentParamConverter: IStudentParamConverter
    {
        public StudentDao StudentDao { get; set; }

        public UniversityDemo.Student Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
