using System;
using UniversityDemo.DataAccess.DataAccessObject.Teacher;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public class TeacherParamConverter: ITeacherParamConverter
    {
        public ITeacherDao Dao { get; set; }

        public TeacherParamConverter(ITeacherDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.Teacher Convert(TeacherParam param)
        {
            throw new NotImplementedException();
        }
    }
}
