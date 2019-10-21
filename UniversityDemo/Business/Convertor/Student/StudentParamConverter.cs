using System;
using UniversityDemo.DataAccess.DataAccessObject.Student;

namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentParamConverter: IStudentParamConverter
    {
        public IStudentDao Dao { get; set; }

        public StudentParamConverter(IStudentDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.Student Convert(StudentParam param)
        {
            throw new NotImplementedException();
        }
    }
}
