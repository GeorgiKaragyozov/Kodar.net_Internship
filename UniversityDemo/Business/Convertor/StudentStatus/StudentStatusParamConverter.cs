using System;
using UniversityDemo.DataAccess.DataAccessObject.StudentStatus;

namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public class StudentStatusParamConverter: IStudentStatusParamConverter
    {
        public StudentStatusDao Dao { get; set; }

        public UniversityDemo.StudentStatus Convert(StudentStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
