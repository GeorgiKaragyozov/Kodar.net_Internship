using System;
using UniversityDemo.DataAccess.DataAccessObject.Student;

namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentParamConverter: IStudentParamConverter
    {
        public StudentDao Dao { get; set; }

        public UniversityDemo.Student Convert(StudentParam param)
        {
            throw new NotImplementedException();
        }
    }
}
