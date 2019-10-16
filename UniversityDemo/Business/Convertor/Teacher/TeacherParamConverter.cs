using System;
using UniversityDemo.DataAccess.DataAccessObject.Teacher;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public class TeacherParamConverter: ITeacherParamConverter
    {
        public TeacherDao Dao { get; set; }

        public UniversityDemo.Teacher Convert(TeacherParam param)
        {
            throw new NotImplementedException();
        }
    }
}
