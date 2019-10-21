using System;
using UniversityDemo.DataAccess.DataAccessObject.StudentStatus;

namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public class StudentStatusParamConverter: IStudentStatusParamConverter
    {
        public IStudentStatusDao Dao { get; set; }

        public StudentStatusParamConverter(IStudentStatusDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.StudentStatus Convert(StudentStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
