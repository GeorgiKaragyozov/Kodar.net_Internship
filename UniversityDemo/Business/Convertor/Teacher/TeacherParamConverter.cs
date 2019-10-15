using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Teacher;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public class TeacherParamConverter: ITeacherParamConverter
    {
        public TeacherDao TeacherDao { get; set; }

        public UniversityDemo.Teacher Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
