using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.StudentStatus;

namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public class StudentStatusParamConverter: IStudentStatusParamConverter
    {
        public StudentStatusDao StudentStatusDao { get; set; }

        public UniversityDemo.StudentStatus Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
